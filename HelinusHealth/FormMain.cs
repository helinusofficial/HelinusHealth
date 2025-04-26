using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HelinusPingUtility
{
    public partial class FormMain : Form
    {
        #region VariableRegion
        internal Utilities utilities;
        Thread th_StartPinging;
        int th_SendPing_Timer = 1000;//1 second
        bool workStatus = false;
        IPClass iPClass;
        LogSrv LogService;
        string tempPingResult = string.Empty;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
            toolStripStatusLabelVer.Text = "Ver:" + utilities.ShowAppVersion();
            labelLocalIP.Text = IPClass.FindLocalIPAddress();
            textBoxIP.Text = utilities.ReadSetting();
            Init();
        }

        #region EventRegion
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        private void toolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            ShutdownApp();
        }

        private void toolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIP.Text.Trim()))
            {
                Init();
                PrintLogMessage("----------------------------------------Start--------------------------------------------", false);
                iPClass = new IPClass(textBoxIP.Text.Trim());
                workStatus = true;
                th_StartPinging.Start();
                ChangeComponents(true);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownApp();
        }
        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLogs.Text = string.Empty;
        }
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                HideMainForm();
            }
        }
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        #endregion

        #region MethodRegion
        private void Init()
        {
            LogService = new LogSrv(Application.StartupPath);
            utilities = new Utilities();
            th_StartPinging = new Thread(new ThreadStart(PingingFunction));
        }
        private void ShutdownApp()
        {
            workStatus = false;
            if (th_StartPinging != null && th_StartPinging.ThreadState != ThreadState.Stopped && th_StartPinging.ThreadState != ThreadState.Unstarted)
            {
                PrintLogMessage("Stoping System", false);
                th_StartPinging.Join();

                PrintLogMessage("Application aborted", false);

                if (iPClass != null)
                {
                    PrintLogMessage("Pinging on computer: " + labelLocalIP.Text, false);

                    PrintLogMessage("IP: " + iPClass.IP + "   Ping Amount: " + iPClass.PingAmount.ToString() +
                                    "   Packet Loss: " + iPClass.PacketLoss.ToString() + "%   Failed Pings: " + iPClass.FailedPings.ToString() +
                                    "   Average Time: " + iPClass.AveragePing.ToString() + "(ms)", false);
                }
                PrintLogMessage("-----------------------------------------------------------------------------------------", false);
                ChangeComponents(false);
            }

        }
        private void PingingFunction()
        {
            while (th_StartPinging.IsAlive && workStatus)
            {
                try
                {
                    tempPingResult = iPClass.PingIt();

                    if (iPClass.PingTime >= 0)
                        PrintLogMessage(iPClass.IP + "       " + iPClass.Address.ToString() + "\t " + tempPingResult + "        TTL= " + iPClass.TTL + "         Ping Time: " + iPClass.PingTime.ToString() + " ms", false);
                    else
                    {
                        if (checkBoxPingFailedSound.Checked)
                            Console.Beep(5000, 100);

                        if (iPClass.Address != null && tempPingResult.Contains("Success"))
                            PrintLogMessage(iPClass.IP + "       " + iPClass.Address.ToString() + "\t " + tempPingResult + "        TTL= " + iPClass.TTL + "         Ping Time: " + iPClass.PingTime.ToString() + " ms", true);
                        else if (iPClass.Address != null && !tempPingResult.Contains("Success"))
                            PrintLogMessage(iPClass.IP + "       " + iPClass.Address.ToString() + "\t Timeout", true);
                        else

                            PrintLogMessage(iPClass.IP + "       There is no IP address available / check your network connection!", true);
                    }

                    labelFailedPings.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelFailedPings.Text = iPClass.FailedPings.ToString();
                    });
                    labelPacketLoss.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelPacketLoss.Text = iPClass.PacketLoss.ToString() + " %";
                    });
                    labelPingAmount.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelPingAmount.Text = iPClass.PingAmount.ToString();
                    });
                    labelAveragePing.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelAveragePing.Text = iPClass.AveragePing.ToString() + " s";
                    });

                }
                catch (Exception err)
                {
                    PrintLogMessage("Ping Error: " + err.Message, true);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(th_SendPing_Timer);
            }
        }
        private void ChangeComponents(bool enableDisable)
        {
            try
            {
                if (enableDisable)
                {
                    labelStatus.ForeColor = System.Drawing.Color.Green;
                    labelStatus.Text = "Connected";
                }
                else
                {
                    labelStatus.ForeColor = System.Drawing.Color.Red;
                    labelStatus.Text = "Disconnected";
                }
                textBoxIP.BeginInvoke((MethodInvoker)delegate ()
                {
                    textBoxIP.Enabled = !enableDisable;
                });
                menuStripMain.BeginInvoke((MethodInvoker)delegate ()
                {
                    toolStripMenuItemStart.Enabled = !enableDisable;
                });
                menuStripMain.BeginInvoke((MethodInvoker)delegate ()
                {
                    toolStripMenuItemStop.Enabled = enableDisable;
                });
                menuStripMain.BeginInvoke((MethodInvoker)delegate ()
                {
                    exitToolStripMenuItem.Enabled = !enableDisable;
                });
            }
            catch { }
        }
        private void PrintLogMessage(string logMessage, bool red)
        {
            try
            {
                lock (this)
                {
                    if(checkBoxWriteLogFile.Checked)
                    LogService.LogIt(logMessage);

                    if (red)
                    {
                        richTextBoxLogs.BeginInvoke((MethodInvoker)delegate ()
                        {
                            // int startIndex = richTextBoxLogs.GetFirstCharIndexFromLine(55);
                            richTextBoxLogs.Select(richTextBoxLogs.Text.Length, logMessage.Length - 1);
                            richTextBoxLogs.SelectionColor = System.Drawing.Color.Red;
                            //richTextBoxLogs.SelectionBackColor = System.Drawing.Color.Blue;
                            richTextBoxLogs.AppendText(LogSrv.LogMessageCreator(logMessage));
                            richTextBoxLogs.ScrollToCaret();
                        });
                    }
                    else
                        richTextBoxLogs.BeginInvoke((MethodInvoker)delegate ()
                        {
                            richTextBoxLogs.AppendText(LogSrv.LogMessageCreator(logMessage));
                            richTextBoxLogs.ScrollToCaret();
                        });
                }
            }
            catch
            {
            }
        }
        private void HideMainForm()
        {
            this.Hide();
            this.Visible = false;
            this.Opacity = 0;
            //this is old code to hide main form in winform
            //this line not works by telerik forms
            // this.WindowState = FormWindowState.Minimized;
            this.Text = string.Empty;
            notifyIconMain.Visible = true;
        }
        private void ShowMainForm()
        {
            notifyIconMain.Visible = false;
            this.Visible = true;
            this.Text = "Ping Utility | Davood Motevalizadeh";
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
        }
        #endregion
    }
}
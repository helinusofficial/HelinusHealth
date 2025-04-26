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
        Thread th_Timer;
        int th_Timer_Timer = 1000;//1 second
        bool workStatus = false;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
            toolStripStatusLabelVer.Text = "Ver:" + utilities.ShowAppVersion();
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
             
                 Init();
              
                 workStatus = true;
                 th_Timer.Start();
                 ChangeComponents(true);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownApp();
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
            utilities = new Utilities();
            th_Timer = new Thread(new ThreadStart(TimerFunction));
        }
        private void ShutdownApp()
        {
            workStatus = false;
            if (th_Timer != null && th_Timer.ThreadState != ThreadState.Stopped && th_Timer.ThreadState != ThreadState.Unstarted)
            {
                th_Timer.Join();
                ChangeComponents(false);
            }

        }
        private void TimerFunction()
        {
            while (th_Timer.IsAlive && workStatus)
            {
                try
                {
                    //labelFailedPings.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    labelFailedPings.Text = iPClass.FailedPings.ToString();
                    //});
                    //labelPacketLoss.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    labelPacketLoss.Text = iPClass.PacketLoss.ToString() + " %";
                    //});
                    //labelPingAmount.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    labelPingAmount.Text = iPClass.PingAmount.ToString();
                    //});
                    //labelAveragePing.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    labelAveragePing.Text = iPClass.AveragePing.ToString() + " s";
                    //});

                }
                catch (Exception err)
                {
                    Thread.Sleep(1000);
                }
                Thread.Sleep(th_Timer_Timer);
            }
        }
        private void ChangeComponents(bool enableDisable)
        {
            try
            {
                labelTimeLeft.BeginInvoke((MethodInvoker)delegate ()
                 {
                     labelTimeLeft.Enabled = !enableDisable;
                 });
                numericUpDownTime.BeginInvoke((MethodInvoker)delegate ()
                {
                    numericUpDownTime.Enabled = !enableDisable;
                });
                buttonStart.BeginInvoke((MethodInvoker)delegate ()
                {
                    buttonStart.Enabled = !enableDisable;
                });
                buttonStop.BeginInvoke((MethodInvoker)delegate ()
                {
                    buttonStop.Enabled = !enableDisable;
                });

                menuStripMain.BeginInvoke((MethodInvoker)delegate ()
                {
                    exitToolStripMenuItem.Enabled = !enableDisable;
                });
            }
            catch { }
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

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}
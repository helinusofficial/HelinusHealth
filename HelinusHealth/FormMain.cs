using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HelinusHealth
{
    public partial class FormMain : Form
    {
        #region VariableRegion
        private double rts = 0;
        private double pts = 0;
        private TimeSpan pastTime;
        private TimeSpan totalSeconds;
        internal Utilities utilities;
        Thread th_Timer;
        int th_Timer_Time = 1000;//1 second
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Init();
            workStatus = true;
            th_Timer.Start();
            ChangeComponents(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ShutdownApp(false);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
            //Application.ExitThread();
            // Invoke(new MethodInvoker(delegate { Application.Exit(); }));

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutdownApp(false);
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
            totalSeconds =new TimeSpan(0);
            pastTime = new TimeSpan(0);
            utilities = new Utilities();
            th_Timer = new Thread(new ThreadStart(TimerFunction));
        }
        private void ShutdownApp(bool stop)
        {
            workStatus = false;
            if (th_Timer != null && th_Timer.ThreadState != ThreadState.Stopped && th_Timer.ThreadState != ThreadState.Unstarted)
            {
                ChangeComponents(false);

                if (stop)
                    ShowMainForm(); 
                
                th_Timer.Join();
            }
        }

 
        private void TimerFunction()
        {
            pts = 0;
             pastTime = TimeSpan.FromSeconds(pts);

            rts = Convert.ToInt32(numericUpDownTime.Value) * 60;
            totalSeconds = TimeSpan.FromSeconds(rts);
         
            
            while (th_Timer.IsAlive && workStatus)
            {
                try
                {
                    pts++;
                    pastTime = TimeSpan.FromSeconds(pts);
                    labelPastTime.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelPastTime.Text = pastTime.Hours + ":" + pastTime.Minutes +
                                              ":" + pastTime.Seconds;
                    });
                    rts--;
                    totalSeconds = TimeSpan.FromSeconds(rts);
                    labelTimeLeft.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelTimeLeft.Text = totalSeconds.Hours+":"+ totalSeconds.Minutes+
                                              ":"+ totalSeconds.Seconds;
                    });

                    if (totalSeconds.TotalSeconds <= 0)
                        ShutdownApp(true);
                }
                catch (Exception err)
                {
                    Thread.Sleep(1000);
                }
                Thread.Sleep(th_Timer_Time);
            }
        }
        private void ChangeComponents(bool enableDisable)
        {
            try
            {
                if (enableDisable)
                {
                   labelStatus.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelStatus.Text = "Work Time :)";
                        labelStatus.ForeColor = Color.Green;
                        Console.Beep(1000, 400);
                    });

                }
                else
                {
                    labelStatus.BeginInvoke((MethodInvoker)delegate ()
                    {
                        labelStatus.Text = "Rest Time :)";
                        labelStatus.ForeColor = Color.Red;
                        Console.Beep(2000, 400);
                    });
                }

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
                    buttonStop.Enabled = enableDisable;
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

            //this.Visible = true;
            //this.Text = "Helinus Health | Davood Motevalizadeh";
            //this.Opacity = 100;
            //this.WindowState = FormWindowState.Normal;

            Invoke(new MethodInvoker(delegate { this.Visible = true; }));
            Invoke(new MethodInvoker(delegate { this.Text = "Helinus Health | Davood Motevalizadeh"; }));
            Invoke(new MethodInvoker(delegate { this.Opacity = 100; }));
            Invoke(new MethodInvoker(delegate { this.WindowState = FormWindowState.Normal; }));
        }
        #endregion
    }
}
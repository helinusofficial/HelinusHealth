namespace HelinusPingUtility
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            statusStripMain = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelVer = new System.Windows.Forms.ToolStripStatusLabel();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxStatus = new System.Windows.Forms.GroupBox();
            checkBoxWriteLogFile = new System.Windows.Forms.CheckBox();
            checkBoxPingFailedSound = new System.Windows.Forms.CheckBox();
            labelLocalIP = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            labelAveragePing = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            labelFailedPings = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelPacketLoss = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelPingAmount = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxIP = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            notifyIconMain = new System.Windows.Forms.NotifyIcon(components);
            groupBoxLogs = new System.Windows.Forms.GroupBox();
            richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            panelControls = new System.Windows.Forms.Panel();
            labelLogoDetail = new System.Windows.Forms.Label();
            labelLogo = new System.Windows.Forms.Label();
            statusStripMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            contextMenuStripMain.SuspendLayout();
            groupBoxLogs.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelVer });
            statusStripMain.Location = new System.Drawing.Point(0, 503);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStripMain.Size = new System.Drawing.Size(807, 22);
            statusStripMain.TabIndex = 0;
            statusStripMain.Text = "Helinus Ping Utility";
            // 
            // toolStripStatusLabelVer
            // 
            toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
            toolStripStatusLabelVer.Size = new System.Drawing.Size(26, 17);
            toolStripStatusLabelVer.Text = "Ver:";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripMain.Size = new System.Drawing.Size(807, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "Helinus Ping Utility";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemStart, toolStripMenuItemStop, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemStart
            // 
            toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            toolStripMenuItemStart.Size = new System.Drawing.Size(98, 22);
            toolStripMenuItemStart.Text = "Start";
            toolStripMenuItemStart.Click += toolStripMenuItemStart_Click;
            // 
            // toolStripMenuItemStop
            // 
            toolStripMenuItemStop.Enabled = false;
            toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            toolStripMenuItemStop.Size = new System.Drawing.Size(98, 22);
            toolStripMenuItemStop.Text = "Stop";
            toolStripMenuItemStop.Click += toolStripMenuItemStop_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { clearLogsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearLogsToolStripMenuItem
            // 
            clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            clearLogsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            clearLogsToolStripMenuItem.Text = "Clear Logs";
            clearLogsToolStripMenuItem.Click += clearLogsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxStatus.Controls.Add(checkBoxWriteLogFile);
            groupBoxStatus.Controls.Add(checkBoxPingFailedSound);
            groupBoxStatus.Controls.Add(labelLocalIP);
            groupBoxStatus.Controls.Add(label7);
            groupBoxStatus.Controls.Add(labelAveragePing);
            groupBoxStatus.Controls.Add(label6);
            groupBoxStatus.Controls.Add(labelFailedPings);
            groupBoxStatus.Controls.Add(label5);
            groupBoxStatus.Controls.Add(labelPacketLoss);
            groupBoxStatus.Controls.Add(label4);
            groupBoxStatus.Controls.Add(labelPingAmount);
            groupBoxStatus.Controls.Add(label3);
            groupBoxStatus.Controls.Add(labelStatus);
            groupBoxStatus.Controls.Add(label2);
            groupBoxStatus.Controls.Add(textBoxIP);
            groupBoxStatus.Controls.Add(label1);
            groupBoxStatus.Location = new System.Drawing.Point(0, 72);
            groupBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Size = new System.Drawing.Size(804, 82);
            groupBoxStatus.TabIndex = 2;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status";
            // 
            // checkBoxWriteLogFile
            // 
            checkBoxWriteLogFile.AutoSize = true;
            checkBoxWriteLogFile.Location = new System.Drawing.Point(700, 20);
            checkBoxWriteLogFile.Name = "checkBoxWriteLogFile";
            checkBoxWriteLogFile.Size = new System.Drawing.Size(98, 19);
            checkBoxWriteLogFile.TabIndex = 15;
            checkBoxWriteLogFile.Text = "Write Log File";
            checkBoxWriteLogFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxPingFailedSound
            // 
            checkBoxPingFailedSound.AutoSize = true;
            checkBoxPingFailedSound.Location = new System.Drawing.Point(700, 53);
            checkBoxPingFailedSound.Name = "checkBoxPingFailedSound";
            checkBoxPingFailedSound.Size = new System.Drawing.Size(94, 19);
            checkBoxPingFailedSound.TabIndex = 14;
            checkBoxPingFailedSound.Text = "Failed Sound";
            checkBoxPingFailedSound.UseVisualStyleBackColor = true;
            // 
            // labelLocalIP
            // 
            labelLocalIP.AutoSize = true;
            labelLocalIP.Location = new System.Drawing.Point(527, 22);
            labelLocalIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLocalIP.Name = "labelLocalIP";
            labelLocalIP.Size = new System.Drawing.Size(13, 15);
            labelLocalIP.TabIndex = 13;
            labelLocalIP.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(471, 22);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Local IP:";
            // 
            // labelAveragePing
            // 
            labelAveragePing.AutoSize = true;
            labelAveragePing.Location = new System.Drawing.Point(560, 55);
            labelAveragePing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAveragePing.Name = "labelAveragePing";
            labelAveragePing.Size = new System.Drawing.Size(12, 15);
            labelAveragePing.TabIndex = 11;
            labelAveragePing.Text = "s";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(471, 55);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 10;
            label6.Text = "Average Time:";
            // 
            // labelFailedPings
            // 
            labelFailedPings.AutoSize = true;
            labelFailedPings.Location = new System.Drawing.Point(401, 55);
            labelFailedPings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFailedPings.Name = "labelFailedPings";
            labelFailedPings.Size = new System.Drawing.Size(13, 15);
            labelFailedPings.TabIndex = 9;
            labelFailedPings.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(324, 55);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Failed Pings:";
            // 
            // labelPacketLoss
            // 
            labelPacketLoss.AutoSize = true;
            labelPacketLoss.Location = new System.Drawing.Point(253, 55);
            labelPacketLoss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPacketLoss.Name = "labelPacketLoss";
            labelPacketLoss.Size = new System.Drawing.Size(23, 15);
            labelPacketLoss.TabIndex = 7;
            labelPacketLoss.Text = "0%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(175, 55);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "Packet Loss: ";
            // 
            // labelPingAmount
            // 
            labelPingAmount.AutoSize = true;
            labelPingAmount.Location = new System.Drawing.Point(96, 55);
            labelPingAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPingAmount.Name = "labelPingAmount";
            labelPingAmount.Size = new System.Drawing.Size(13, 15);
            labelPingAmount.TabIndex = 5;
            labelPingAmount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 55);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Ping Amount: ";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = System.Drawing.Color.Red;
            labelStatus.Location = new System.Drawing.Point(329, 23);
            labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(79, 15);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Disconnected";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(285, 23);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new System.Drawing.Point(47, 18);
            textBoxIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new System.Drawing.Size(188, 23);
            textBoxIP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemShow, aboutToolStripMenuItemAbout });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new System.Drawing.Size(165, 48);
            // 
            // toolStripMenuItemShow
            // 
            toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            toolStripMenuItemShow.Size = new System.Drawing.Size(164, 22);
            toolStripMenuItemShow.Text = "Show Ping Utility";
            toolStripMenuItemShow.Click += toolStripMenuItemShow_Click;
            // 
            // aboutToolStripMenuItemAbout
            // 
            aboutToolStripMenuItemAbout.Name = "aboutToolStripMenuItemAbout";
            aboutToolStripMenuItemAbout.Size = new System.Drawing.Size(164, 22);
            aboutToolStripMenuItemAbout.Text = "About";
            aboutToolStripMenuItemAbout.Click += aboutToolStripMenuItem1_Click;
            // 
            // notifyIconMain
            // 
            notifyIconMain.ContextMenuStrip = contextMenuStripMain;
            notifyIconMain.Icon = (System.Drawing.Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "Ping Utility";
            notifyIconMain.Visible = true;
            // 
            // groupBoxLogs
            // 
            groupBoxLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxLogs.Controls.Add(richTextBoxLogs);
            groupBoxLogs.Location = new System.Drawing.Point(0, 160);
            groupBoxLogs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLogs.Name = "groupBoxLogs";
            groupBoxLogs.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLogs.Size = new System.Drawing.Size(807, 336);
            groupBoxLogs.TabIndex = 3;
            groupBoxLogs.TabStop = false;
            groupBoxLogs.Text = "Logs";
            // 
            // richTextBoxLogs
            // 
            richTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxLogs.Location = new System.Drawing.Point(4, 19);
            richTextBoxLogs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new System.Drawing.Size(799, 314);
            richTextBoxLogs.TabIndex = 0;
            richTextBoxLogs.Text = "";
            // 
            // panelControls
            // 
            panelControls.BackColor = System.Drawing.Color.FromArgb(15, 78, 132);
            panelControls.Controls.Add(labelLogoDetail);
            panelControls.Controls.Add(labelLogo);
            panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            panelControls.Location = new System.Drawing.Point(0, 24);
            panelControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControls.Name = "panelControls";
            panelControls.Size = new System.Drawing.Size(807, 37);
            panelControls.TabIndex = 4;
            // 
            // labelLogoDetail
            // 
            labelLogoDetail.AutoSize = true;
            labelLogoDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogoDetail.ForeColor = System.Drawing.Color.Silver;
            labelLogoDetail.Location = new System.Drawing.Point(96, 15);
            labelLogoDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogoDetail.Name = "labelLogoDetail";
            labelLogoDetail.Size = new System.Drawing.Size(63, 12);
            labelLogoDetail.TabIndex = 3;
            labelLogoDetail.Text = "Ping Utility";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogo.ForeColor = System.Drawing.Color.White;
            labelLogo.Location = new System.Drawing.Point(8, 6);
            labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new System.Drawing.Size(77, 22);
            labelLogo.TabIndex = 2;
            labelLogo.Text = "Helinus";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(807, 525);
            Controls.Add(panelControls);
            Controls.Add(groupBoxLogs);
            Controls.Add(groupBoxStatus);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Helinus Ping Utility";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            contextMenuStripMain.ResumeLayout(false);
            groupBoxLogs.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVer;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPacketLoss;
        private System.Windows.Forms.Label labelFailedPings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAveragePing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItemAbout;
        private System.Windows.Forms.Label labelLocalIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxLogs;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelLogoDetail;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.CheckBox checkBoxPingFailedSound;
        private System.Windows.Forms.CheckBox checkBoxWriteLogFile;
    }
}
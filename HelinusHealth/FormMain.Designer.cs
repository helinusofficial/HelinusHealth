﻿namespace HelinusHealth
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
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxStatus = new System.Windows.Forms.GroupBox();
            labelPastTime = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelTimeLeft = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            labelTime = new System.Windows.Forms.Label();
            buttonStop = new System.Windows.Forms.Button();
            buttonStart = new System.Windows.Forms.Button();
            contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            notifyIconMain = new System.Windows.Forms.NotifyIcon(components);
            panelControls = new System.Windows.Forms.Panel();
            labelLogoDetail = new System.Windows.Forms.Label();
            labelLogo = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            statusStripMain.SuspendLayout();
            menuStripMain.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            contextMenuStripMain.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelVer });
            statusStripMain.Location = new System.Drawing.Point(0, 243);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStripMain.Size = new System.Drawing.Size(387, 22);
            statusStripMain.TabIndex = 0;
            statusStripMain.Text = "Helinus Health";
            // 
            // toolStripStatusLabelVer
            // 
            toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
            toolStripStatusLabelVer.Size = new System.Drawing.Size(26, 17);
            toolStripStatusLabelVer.Text = "Ver:";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripMain.Size = new System.Drawing.Size(387, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "Helinus Health";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            groupBoxStatus.Controls.Add(labelPastTime);
            groupBoxStatus.Controls.Add(label2);
            groupBoxStatus.Controls.Add(labelTimeLeft);
            groupBoxStatus.Controls.Add(label1);
            groupBoxStatus.Controls.Add(numericUpDownTime);
            groupBoxStatus.Controls.Add(labelTime);
            groupBoxStatus.Controls.Add(buttonStop);
            groupBoxStatus.Controls.Add(buttonStart);
            groupBoxStatus.Location = new System.Drawing.Point(0, 72);
            groupBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Size = new System.Drawing.Size(386, 110);
            groupBoxStatus.TabIndex = 2;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status";
            // 
            // labelPastTime
            // 
            labelPastTime.AutoSize = true;
            labelPastTime.Location = new System.Drawing.Point(247, 40);
            labelPastTime.Name = "labelPastTime";
            labelPastTime.Size = new System.Drawing.Size(13, 15);
            labelPastTime.TabIndex = 7;
            labelPastTime.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(216, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Past:";
            // 
            // labelTimeLeft
            // 
            labelTimeLeft.AutoSize = true;
            labelTimeLeft.Location = new System.Drawing.Point(247, 20);
            labelTimeLeft.Name = "labelTimeLeft";
            labelTimeLeft.Size = new System.Drawing.Size(13, 15);
            labelTimeLeft.TabIndex = 5;
            labelTimeLeft.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(216, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Left:";
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new System.Drawing.Point(116, 25);
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new System.Drawing.Size(61, 23);
            numericUpDownTime.TabIndex = 3;
            numericUpDownTime.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new System.Drawing.Point(12, 29);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(98, 15);
            labelTime.TabIndex = 2;
            labelTime.Text = "Time (In Minute):";
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new System.Drawing.Point(181, 70);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(91, 70);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemShow, aboutToolStripMenuItemAbout });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new System.Drawing.Size(185, 48);
            // 
            // toolStripMenuItemShow
            // 
            toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            toolStripMenuItemShow.Size = new System.Drawing.Size(184, 22);
            toolStripMenuItemShow.Text = "Show Helinus Health";
            toolStripMenuItemShow.Click += toolStripMenuItemShow_Click;
            // 
            // aboutToolStripMenuItemAbout
            // 
            aboutToolStripMenuItemAbout.Name = "aboutToolStripMenuItemAbout";
            aboutToolStripMenuItemAbout.Size = new System.Drawing.Size(184, 22);
            aboutToolStripMenuItemAbout.Text = "About";
            aboutToolStripMenuItemAbout.Click += aboutToolStripMenuItem1_Click;
            // 
            // notifyIconMain
            // 
            notifyIconMain.ContextMenuStrip = contextMenuStripMain;
            notifyIconMain.Icon = (System.Drawing.Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "Health";
            notifyIconMain.Visible = true;
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
            panelControls.Size = new System.Drawing.Size(387, 37);
            panelControls.TabIndex = 4;
            // 
            // labelLogoDetail
            // 
            labelLogoDetail.AutoSize = true;
            labelLogoDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogoDetail.ForeColor = System.Drawing.Color.Silver;
            labelLogoDetail.Location = new System.Drawing.Point(82, 14);
            labelLogoDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogoDetail.Name = "labelLogoDetail";
            labelLogoDetail.Size = new System.Drawing.Size(41, 12);
            labelLogoDetail.TabIndex = 3;
            labelLogoDetail.Text = "Health";
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
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new System.Drawing.Font("Segoe UI", 25F);
            labelStatus.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
            labelStatus.Location = new System.Drawing.Point(8, 185);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(34, 46);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "-";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(387, 265);
            Controls.Add(labelStatus);
            Controls.Add(panelControls);
            Controls.Add(groupBoxStatus);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Helinus Health";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            contextMenuStripMain.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItemAbout;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelLogoDetail;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPastTime;
    }
}
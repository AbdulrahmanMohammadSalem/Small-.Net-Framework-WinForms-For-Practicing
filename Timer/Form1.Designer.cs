namespace Timer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.notifyIcon_timerIsUp = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon_hide = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_trayStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_trayPause = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_trayReset = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_trayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_trayTimer = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_seconds = new System.Windows.Forms.TextBox();
            this.txtBox_hours = new System.Windows.Forms.TextBox();
            this.txtBox_minutes = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.label1.Location = new System.Drawing.Point(217, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "h,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.label2.Location = new System.Drawing.Point(343, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "m,";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.label3.Location = new System.Drawing.Point(479, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_start
            // 
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btn_start.Location = new System.Drawing.Point(258, 246);
            this.btn_start.Margin = new System.Windows.Forms.Padding(6);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 47);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btn_reset.Location = new System.Drawing.Point(522, 246);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(6);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 47);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Enabled = false;
            this.btn_pause.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btn_pause.Location = new System.Drawing.Point(390, 246);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(6);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(120, 47);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(545, 14);
            this.progressBar1.Step = 16;
            this.progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F);
            this.lbl_percentage.Location = new System.Drawing.Point(563, 9);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(82, 30);
            this.lbl_percentage.TabIndex = 10;
            this.lbl_percentage.Text = "0.00%";
            this.lbl_percentage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_hide
            // 
            this.btn_hide.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_hide.Enabled = false;
            this.btn_hide.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btn_hide.Location = new System.Drawing.Point(12, 246);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(6);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(120, 47);
            this.btn_hide.TabIndex = 11;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // notifyIcon_timerIsUp
            // 
            this.notifyIcon_timerIsUp.BalloonTipText = "The timer is up.";
            this.notifyIcon_timerIsUp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_timerIsUp.Icon")));
            this.notifyIcon_timerIsUp.Text = "notifyIcon_timerIsUp";
            this.notifyIcon_timerIsUp.BalloonTipClicked += new System.EventHandler(this.notifyIcon_timerIsUp_BalloonTipClicked);
            this.notifyIcon_timerIsUp.BalloonTipClosed += new System.EventHandler(this.notifyIcon_timerIsUp_BalloonTipClosed);
            // 
            // notifyIcon_hide
            // 
            this.notifyIcon_hide.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_hide.BalloonTipText = "The timer is still running in the tray.";
            this.notifyIcon_hide.BalloonTipTitle = "Hidden";
            this.notifyIcon_hide.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon_hide.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_hide.Icon")));
            this.notifyIcon_hide.Text = "Timer";
            this.notifyIcon_hide.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_hide_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_trayStart,
            this.btn_trayPause,
            this.btn_trayReset,
            this.btn_trayShow,
            this.lbl_trayTimer,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 153);
            // 
            // btn_trayStart
            // 
            this.btn_trayStart.Enabled = false;
            this.btn_trayStart.Name = "btn_trayStart";
            this.btn_trayStart.Size = new System.Drawing.Size(160, 24);
            this.btn_trayStart.Text = "Start";
            this.btn_trayStart.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_trayPause
            // 
            this.btn_trayPause.Name = "btn_trayPause";
            this.btn_trayPause.Size = new System.Drawing.Size(160, 24);
            this.btn_trayPause.Text = "Pause";
            this.btn_trayPause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_trayReset
            // 
            this.btn_trayReset.Enabled = false;
            this.btn_trayReset.Name = "btn_trayReset";
            this.btn_trayReset.Size = new System.Drawing.Size(160, 24);
            this.btn_trayReset.Text = "Reset";
            this.btn_trayReset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_trayShow
            // 
            this.btn_trayShow.Name = "btn_trayShow";
            this.btn_trayShow.Size = new System.Drawing.Size(160, 24);
            this.btn_trayShow.Text = "Show";
            this.btn_trayShow.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // lbl_trayTimer
            // 
            this.lbl_trayTimer.Enabled = false;
            this.lbl_trayTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_trayTimer.Name = "lbl_trayTimer";
            this.lbl_trayTimer.Size = new System.Drawing.Size(100, 27);
            this.lbl_trayTimer.Text = "00:00:00";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtBox_seconds
            // 
            this.txtBox_seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_seconds.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.txtBox_seconds.Location = new System.Drawing.Point(405, 91);
            this.txtBox_seconds.MaxLength = 2;
            this.txtBox_seconds.Name = "txtBox_seconds";
            this.txtBox_seconds.Size = new System.Drawing.Size(68, 52);
            this.txtBox_seconds.TabIndex = 13;
            this.txtBox_seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBox_hours
            // 
            this.txtBox_hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_hours.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.txtBox_hours.Location = new System.Drawing.Point(143, 91);
            this.txtBox_hours.MaxLength = 2;
            this.txtBox_hours.Name = "txtBox_hours";
            this.txtBox_hours.Size = new System.Drawing.Size(68, 52);
            this.txtBox_hours.TabIndex = 14;
            this.txtBox_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBox_minutes
            // 
            this.txtBox_minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_minutes.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F);
            this.txtBox_minutes.Location = new System.Drawing.Point(269, 91);
            this.txtBox_minutes.MaxLength = 2;
            this.txtBox_minutes.Name = "txtBox_minutes";
            this.txtBox_minutes.Size = new System.Drawing.Size(68, 52);
            this.txtBox_minutes.TabIndex = 15;
            this.txtBox_minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 308);
            this.Controls.Add(this.txtBox_minutes);
            this.Controls.Add(this.txtBox_hours);
            this.Controls.Add(this.txtBox_seconds);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_percentage;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.NotifyIcon notifyIcon_timerIsUp;
        private System.Windows.Forms.NotifyIcon notifyIcon_hide;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_trayStart;
        private System.Windows.Forms.ToolStripMenuItem btn_trayPause;
        private System.Windows.Forms.ToolStripMenuItem btn_trayReset;
        private System.Windows.Forms.ToolStripMenuItem btn_trayShow;
        private System.Windows.Forms.ToolStripTextBox lbl_trayTimer;
        private System.Windows.Forms.TextBox txtBox_seconds;
        private System.Windows.Forms.TextBox txtBox_hours;
        private System.Windows.Forms.TextBox txtBox_minutes;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


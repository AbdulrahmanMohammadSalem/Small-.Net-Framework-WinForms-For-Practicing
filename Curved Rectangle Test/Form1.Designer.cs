namespace Curved_Rectangle_Test {
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_X = new System.Windows.Forms.TrackBar();
            this.label_X = new System.Windows.Forms.Label();
            this.trackBar_Radius = new System.Windows.Forms.TrackBar();
            this.label_Radius = new System.Windows.Forms.Label();
            this.trackBar_Height = new System.Windows.Forms.TrackBar();
            this.label_Height = new System.Windows.Forms.Label();
            this.trackBar_Width = new System.Windows.Forms.TrackBar();
            this.label_Width = new System.Windows.Forms.Label();
            this.trackBar_Y = new System.Windows.Forms.TrackBar();
            this.label_Y = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_Thickness = new System.Windows.Forms.TrackBar();
            this.label_Thickness = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_SolidFill = new System.Windows.Forms.RadioButton();
            this.radioButton_GradientFill = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_SolidFillOptions = new System.Windows.Forms.GroupBox();
            this.linkLabel_ChooseBackColor = new System.Windows.Forms.LinkLabel();
            this.groupBox_GradientFillOptions = new System.Windows.Forms.GroupBox();
            this.textBox_SetGRAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel_ChooseGRStartColor = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ChooseGrEndColor = new System.Windows.Forms.LinkLabel();
            this.btn_ChangeBorderColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Thickness)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_SolidFillOptions.SuspendLayout();
            this.groupBox_GradientFillOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter username:";
            // 
            // trackBar_X
            // 
            this.trackBar_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_X.AutoSize = false;
            this.trackBar_X.Location = new System.Drawing.Point(114, 12);
            this.trackBar_X.Maximum = 2000;
            this.trackBar_X.Name = "trackBar_X";
            this.trackBar_X.Size = new System.Drawing.Size(620, 24);
            this.trackBar_X.TabIndex = 34;
            this.trackBar_X.TickFrequency = 15;
            this.trackBar_X.Scroll += new System.EventHandler(this.trackBar_X_Scroll);
            // 
            // label_X
            // 
            this.label_X.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_X.Location = new System.Drawing.Point(740, 14);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(50, 20);
            this.label_X.TabIndex = 35;
            this.label_X.Text = "0";
            this.label_X.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar_Radius
            // 
            this.trackBar_Radius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Radius.AutoSize = false;
            this.trackBar_Radius.Location = new System.Drawing.Point(114, 132);
            this.trackBar_Radius.Maximum = 2000;
            this.trackBar_Radius.Name = "trackBar_Radius";
            this.trackBar_Radius.Size = new System.Drawing.Size(620, 24);
            this.trackBar_Radius.TabIndex = 32;
            this.trackBar_Radius.TickFrequency = 15;
            this.trackBar_Radius.Scroll += new System.EventHandler(this.trackBar_Radius_Scroll);
            // 
            // label_Radius
            // 
            this.label_Radius.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Radius.Location = new System.Drawing.Point(740, 132);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(50, 20);
            this.label_Radius.TabIndex = 33;
            this.label_Radius.Text = "0";
            this.label_Radius.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar_Height
            // 
            this.trackBar_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Height.AutoSize = false;
            this.trackBar_Height.Location = new System.Drawing.Point(114, 102);
            this.trackBar_Height.Maximum = 2000;
            this.trackBar_Height.Name = "trackBar_Height";
            this.trackBar_Height.Size = new System.Drawing.Size(620, 24);
            this.trackBar_Height.TabIndex = 30;
            this.trackBar_Height.TickFrequency = 15;
            this.trackBar_Height.Scroll += new System.EventHandler(this.trackBar_Height_Scroll);
            // 
            // label_Height
            // 
            this.label_Height.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Height.Location = new System.Drawing.Point(740, 101);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(50, 20);
            this.label_Height.TabIndex = 31;
            this.label_Height.Text = "0";
            this.label_Height.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar_Width
            // 
            this.trackBar_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Width.AutoSize = false;
            this.trackBar_Width.Location = new System.Drawing.Point(114, 72);
            this.trackBar_Width.Maximum = 2000;
            this.trackBar_Width.Name = "trackBar_Width";
            this.trackBar_Width.Size = new System.Drawing.Size(620, 24);
            this.trackBar_Width.TabIndex = 28;
            this.trackBar_Width.TickFrequency = 15;
            this.trackBar_Width.Scroll += new System.EventHandler(this.trackBar_Width_Scroll);
            // 
            // label_Width
            // 
            this.label_Width.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Width.Location = new System.Drawing.Point(740, 71);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(50, 20);
            this.label_Width.TabIndex = 29;
            this.label_Width.Text = "0";
            this.label_Width.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar_Y
            // 
            this.trackBar_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Y.AutoSize = false;
            this.trackBar_Y.Location = new System.Drawing.Point(114, 42);
            this.trackBar_Y.Maximum = 2000;
            this.trackBar_Y.Name = "trackBar_Y";
            this.trackBar_Y.Size = new System.Drawing.Size(620, 24);
            this.trackBar_Y.TabIndex = 26;
            this.trackBar_Y.TickFrequency = 15;
            this.trackBar_Y.Scroll += new System.EventHandler(this.trackBar_Y_Scroll);
            // 
            // label_Y
            // 
            this.label_Y.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Y.Location = new System.Drawing.Point(740, 42);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(50, 20);
            this.label_Y.TabIndex = 27;
            this.label_Y.Text = "0";
            this.label_Y.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 129);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4);
            this.label7.Size = new System.Drawing.Size(76, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Radius:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Height:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Width:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(33, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(34, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thickness:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar_Thickness
            // 
            this.trackBar_Thickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Thickness.AutoSize = false;
            this.trackBar_Thickness.Location = new System.Drawing.Point(114, 162);
            this.trackBar_Thickness.Maximum = 30;
            this.trackBar_Thickness.Name = "trackBar_Thickness";
            this.trackBar_Thickness.Size = new System.Drawing.Size(620, 24);
            this.trackBar_Thickness.TabIndex = 18;
            this.trackBar_Thickness.Scroll += new System.EventHandler(this.trackBar_Thickness_Scroll);
            // 
            // label_Thickness
            // 
            this.label_Thickness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Thickness.Location = new System.Drawing.Point(740, 162);
            this.label_Thickness.Name = "label_Thickness";
            this.label_Thickness.Size = new System.Drawing.Size(50, 20);
            this.label_Thickness.TabIndex = 19;
            this.label_Thickness.Text = "0";
            this.label_Thickness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_SolidFill);
            this.panel1.Controls.Add(this.radioButton_GradientFill);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox_SolidFillOptions);
            this.panel1.Controls.Add(this.groupBox_GradientFillOptions);
            this.panel1.Controls.Add(this.btn_ChangeBorderColor);
            this.panel1.Controls.Add(this.trackBar_X);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.trackBar_Radius);
            this.panel1.Controls.Add(this.label_Radius);
            this.panel1.Controls.Add(this.trackBar_Height);
            this.panel1.Controls.Add(this.label_Height);
            this.panel1.Controls.Add(this.trackBar_Width);
            this.panel1.Controls.Add(this.label_Width);
            this.panel1.Controls.Add(this.trackBar_Y);
            this.panel1.Controls.Add(this.label_Y);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar_Thickness);
            this.panel1.Controls.Add(this.label_Thickness);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 236);
            this.panel1.TabIndex = 20;
            // 
            // radioButton_SolidFill
            // 
            this.radioButton_SolidFill.AutoSize = true;
            this.radioButton_SolidFill.Checked = true;
            this.radioButton_SolidFill.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.radioButton_SolidFill.Location = new System.Drawing.Point(332, 191);
            this.radioButton_SolidFill.Name = "radioButton_SolidFill";
            this.radioButton_SolidFill.Padding = new System.Windows.Forms.Padding(4);
            this.radioButton_SolidFill.Size = new System.Drawing.Size(93, 32);
            this.radioButton_SolidFill.TabIndex = 43;
            this.radioButton_SolidFill.TabStop = true;
            this.radioButton_SolidFill.Tag = Curved_Rectangle_Test.Form1.Modes.SolidFill;
            this.radioButton_SolidFill.Text = "Solid fill";
            this.radioButton_SolidFill.UseVisualStyleBackColor = true;
            this.radioButton_SolidFill.CheckedChanged += new System.EventHandler(this.radioButton_FillMode_CheckedChanged);
            // 
            // radioButton_GradientFill
            // 
            this.radioButton_GradientFill.AutoSize = true;
            this.radioButton_GradientFill.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.radioButton_GradientFill.Location = new System.Drawing.Point(214, 191);
            this.radioButton_GradientFill.Name = "radioButton_GradientFill";
            this.radioButton_GradientFill.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.radioButton_GradientFill.Size = new System.Drawing.Size(112, 32);
            this.radioButton_GradientFill.TabIndex = 42;
            this.radioButton_GradientFill.Tag = Curved_Rectangle_Test.Form1.Modes.GradientFill;
            this.radioButton_GradientFill.Text = "Gradient fill";
            this.radioButton_GradientFill.UseVisualStyleBackColor = true;
            this.radioButton_GradientFill.CheckedChanged += new System.EventHandler(this.radioButton_FillMode_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 192);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.label8.Size = new System.Drawing.Size(194, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Background fill mode:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_SolidFillOptions
            // 
            this.groupBox_SolidFillOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SolidFillOptions.Controls.Add(this.linkLabel_ChooseBackColor);
            this.groupBox_SolidFillOptions.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.groupBox_SolidFillOptions.Location = new System.Drawing.Point(796, 134);
            this.groupBox_SolidFillOptions.Name = "groupBox_SolidFillOptions";
            this.groupBox_SolidFillOptions.Size = new System.Drawing.Size(326, 54);
            this.groupBox_SolidFillOptions.TabIndex = 40;
            this.groupBox_SolidFillOptions.TabStop = false;
            this.groupBox_SolidFillOptions.Text = "Solid fill";
            // 
            // linkLabel_ChooseBackColor
            // 
            this.linkLabel_ChooseBackColor.AutoSize = true;
            this.linkLabel_ChooseBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_ChooseBackColor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_ChooseBackColor.Location = new System.Drawing.Point(6, 23);
            this.linkLabel_ChooseBackColor.Name = "linkLabel_ChooseBackColor";
            this.linkLabel_ChooseBackColor.Size = new System.Drawing.Size(117, 20);
            this.linkLabel_ChooseBackColor.TabIndex = 1;
            this.linkLabel_ChooseBackColor.TabStop = true;
            this.linkLabel_ChooseBackColor.Text = "Choose fill color";
            this.linkLabel_ChooseBackColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ChooseBackColor_LinkClicked);
            // 
            // groupBox_GradientFillOptions
            // 
            this.groupBox_GradientFillOptions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_GradientFillOptions.Controls.Add(this.textBox_SetGRAngle);
            this.groupBox_GradientFillOptions.Controls.Add(this.label9);
            this.groupBox_GradientFillOptions.Controls.Add(this.linkLabel_ChooseGRStartColor);
            this.groupBox_GradientFillOptions.Controls.Add(this.linkLabel_ChooseGrEndColor);
            this.groupBox_GradientFillOptions.Enabled = false;
            this.groupBox_GradientFillOptions.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.groupBox_GradientFillOptions.Location = new System.Drawing.Point(796, 14);
            this.groupBox_GradientFillOptions.Name = "groupBox_GradientFillOptions";
            this.groupBox_GradientFillOptions.Size = new System.Drawing.Size(326, 115);
            this.groupBox_GradientFillOptions.TabIndex = 39;
            this.groupBox_GradientFillOptions.TabStop = false;
            this.groupBox_GradientFillOptions.Text = "Gradient fill";
            // 
            // textBox_SetGRAngle
            // 
            this.textBox_SetGRAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SetGRAngle.Location = new System.Drawing.Point(103, 80);
            this.textBox_SetGRAngle.MaxLength = 3;
            this.textBox_SetGRAngle.Name = "textBox_SetGRAngle";
            this.textBox_SetGRAngle.Size = new System.Drawing.Size(136, 27);
            this.textBox_SetGRAngle.TabIndex = 3;
            this.textBox_SetGRAngle.Text = "0";
            this.textBox_SetGRAngle.TextChanged += new System.EventHandler(this.textBox_SetGRAngle_TextChanged);
            this.textBox_SetGRAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SetGRAngle_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Angle (deg):";
            // 
            // linkLabel_ChooseGRStartColor
            // 
            this.linkLabel_ChooseGRStartColor.AutoSize = true;
            this.linkLabel_ChooseGRStartColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_ChooseGRStartColor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_ChooseGRStartColor.Location = new System.Drawing.Point(6, 27);
            this.linkLabel_ChooseGRStartColor.Name = "linkLabel_ChooseGRStartColor";
            this.linkLabel_ChooseGRStartColor.Size = new System.Drawing.Size(129, 20);
            this.linkLabel_ChooseGRStartColor.TabIndex = 1;
            this.linkLabel_ChooseGRStartColor.TabStop = true;
            this.linkLabel_ChooseGRStartColor.Text = "Choose start color";
            this.linkLabel_ChooseGRStartColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ChooseGRStartColor_LinkClicked);
            // 
            // linkLabel_ChooseGrEndColor
            // 
            this.linkLabel_ChooseGrEndColor.AutoSize = true;
            this.linkLabel_ChooseGrEndColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_ChooseGrEndColor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_ChooseGrEndColor.Location = new System.Drawing.Point(6, 55);
            this.linkLabel_ChooseGrEndColor.Name = "linkLabel_ChooseGrEndColor";
            this.linkLabel_ChooseGrEndColor.Size = new System.Drawing.Size(125, 20);
            this.linkLabel_ChooseGrEndColor.TabIndex = 0;
            this.linkLabel_ChooseGrEndColor.TabStop = true;
            this.linkLabel_ChooseGrEndColor.Text = "Choose end color";
            this.linkLabel_ChooseGrEndColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ChooseGrEndColor_LinkClicked);
            // 
            // btn_ChangeBorderColor
            // 
            this.btn_ChangeBorderColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeBorderColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeBorderColor.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.btn_ChangeBorderColor.Location = new System.Drawing.Point(796, 194);
            this.btn_ChangeBorderColor.Name = "btn_ChangeBorderColor";
            this.btn_ChangeBorderColor.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_ChangeBorderColor.Size = new System.Drawing.Size(326, 32);
            this.btn_ChangeBorderColor.TabIndex = 36;
            this.btn_ChangeBorderColor.Text = "Change Border Color";
            this.btn_ChangeBorderColor.UseVisualStyleBackColor = true;
            this.btn_ChangeBorderColor.Click += new System.EventHandler(this.btn_ChangeBorderColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(850, 700);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Curved Rectangle Test";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Thickness)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_SolidFillOptions.ResumeLayout(false);
            this.groupBox_SolidFillOptions.PerformLayout();
            this.groupBox_GradientFillOptions.ResumeLayout(false);
            this.groupBox_GradientFillOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_X;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TrackBar trackBar_Radius;
        private System.Windows.Forms.Label label_Radius;
        private System.Windows.Forms.TrackBar trackBar_Height;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TrackBar trackBar_Width;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.TrackBar trackBar_Y;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_Thickness;
        private System.Windows.Forms.Label label_Thickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_GradientFill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_SolidFillOptions;
        private System.Windows.Forms.GroupBox groupBox_GradientFillOptions;
        private System.Windows.Forms.RadioButton radioButton_SolidFill;
        private System.Windows.Forms.LinkLabel linkLabel_ChooseBackColor;
        private System.Windows.Forms.LinkLabel linkLabel_ChooseGRStartColor;
        private System.Windows.Forms.LinkLabel linkLabel_ChooseGrEndColor;
        private System.Windows.Forms.TextBox textBox_SetGRAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ChangeBorderColor;
    }
}


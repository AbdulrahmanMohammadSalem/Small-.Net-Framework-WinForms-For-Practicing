namespace Simple_Calculator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_display = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.btn_zero = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_display
            // 
            this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_display.Font = new System.Drawing.Font("Latin Modern Math", 16F);
            this.lbl_display.Location = new System.Drawing.Point(26, 61);
            this.lbl_display.Margin = new System.Windows.Forms.Padding(7);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(278, 42);
            this.lbl_display.TabIndex = 0;
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_operation
            // 
            this.lbl_operation.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.lbl_operation.Location = new System.Drawing.Point(26, 9);
            this.lbl_operation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(278, 45);
            this.lbl_operation.TabIndex = 1;
            this.lbl_operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.btn_zero.Location = new System.Drawing.Point(26, 413);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(7);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_zero.Size = new System.Drawing.Size(60, 60);
            this.btn_zero.TabIndex = 2;
            this.btn_zero.Tag = "0";
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button2.Location = new System.Drawing.Point(100, 413);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 3;
            this.button2.Tag = ".";
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_decimalPoint_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button3.Location = new System.Drawing.Point(170, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(7);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 4;
            this.button3.Tag = "%";
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_percent_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button4.Location = new System.Drawing.Point(244, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(7);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 5;
            this.button4.Tag = "/";
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button5.Location = new System.Drawing.Point(244, 191);
            this.button5.Margin = new System.Windows.Forms.Padding(7);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 6;
            this.button5.Tag = "*";
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button6.Location = new System.Drawing.Point(244, 265);
            this.button6.Margin = new System.Windows.Forms.Padding(7);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 7;
            this.button6.Tag = "-";
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button7.Location = new System.Drawing.Point(244, 339);
            this.button7.Margin = new System.Windows.Forms.Padding(7);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 8;
            this.button7.Tag = "+";
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button9.Location = new System.Drawing.Point(174, 191);
            this.button9.Margin = new System.Windows.Forms.Padding(7);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 10;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button10.Location = new System.Drawing.Point(100, 191);
            this.button10.Margin = new System.Windows.Forms.Padding(7);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 11;
            this.button10.Tag = "8";
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button11.Location = new System.Drawing.Point(26, 191);
            this.button11.Margin = new System.Windows.Forms.Padding(7);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 12;
            this.button11.Tag = "7";
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button12.Location = new System.Drawing.Point(174, 265);
            this.button12.Margin = new System.Windows.Forms.Padding(7);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 13;
            this.button12.Tag = "6";
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button13.Location = new System.Drawing.Point(100, 265);
            this.button13.Margin = new System.Windows.Forms.Padding(7);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 14;
            this.button13.Tag = "5";
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button14.Location = new System.Drawing.Point(26, 265);
            this.button14.Margin = new System.Windows.Forms.Padding(7);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 15;
            this.button14.Tag = "4";
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button15.Location = new System.Drawing.Point(174, 339);
            this.button15.Margin = new System.Windows.Forms.Padding(7);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 16;
            this.button15.Tag = "3";
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button16.Location = new System.Drawing.Point(100, 339);
            this.button16.Margin = new System.Windows.Forms.Padding(7);
            this.button16.Name = "button16";
            this.button16.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button16.Size = new System.Drawing.Size(60, 60);
            this.button16.TabIndex = 17;
            this.button16.Tag = "2";
            this.button16.Text = "2";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.button17.Location = new System.Drawing.Point(26, 339);
            this.button17.Margin = new System.Windows.Forms.Padding(7);
            this.button17.Name = "button17";
            this.button17.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button17.Size = new System.Drawing.Size(60, 60);
            this.button17.TabIndex = 18;
            this.button17.Tag = "1";
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Font = new System.Drawing.Font("Latin Modern Math (Modified)", 16F);
            this.btn_evaluate.Location = new System.Drawing.Point(172, 413);
            this.btn_evaluate.Margin = new System.Windows.Forms.Padding(7);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_evaluate.Size = new System.Drawing.Size(132, 60);
            this.btn_evaluate.TabIndex = 19;
            this.btn_evaluate.Text = "=";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Cambria Math", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(96, 117);
            this.button19.Margin = new System.Windows.Forms.Padding(7);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 20;
            this.button19.Tag = "√";
            this.button19.Text = "√";
            this.button19.UseCompatibleTextRendering = true;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F);
            this.btn_ac.Location = new System.Drawing.Point(26, 117);
            this.btn_ac.Margin = new System.Windows.Forms.Padding(7);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(60, 60);
            this.btn_ac.TabIndex = 21;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 495);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.lbl_display);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btn_ac;
    }
}


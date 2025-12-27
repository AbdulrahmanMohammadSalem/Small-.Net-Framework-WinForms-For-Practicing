using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Curved_Rectangle_Test {
    public partial class Form1 : Form {
        private enum Modes : byte {
            SolidFill, GradientFill
        }

        private short X = 0;
        private short Y = 0;
        private short WIDTH = 0;
        private short HEIGHT = 0;
        private short RADIUS = 0;
        private short THICKNESS = 0;
        private Color BORDER_COLOR = Color.Black, BACK_COLOR = SystemColors.Control;
        private Color GR_START_COLOR = SystemColors.Control, GR_END_COLOR = SystemColors.Control;
        private short GR_ANGLE;
        private Modes ACTIVE_MODE = Modes.SolidFill;

        Pen myPen = new Pen(Color.Black) {
            StartCap = LineCap.Round,
            EndCap = LineCap.Round
        };

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            RefreshRectangle(e.Graphics);
        }

        private void RefreshRectangle(Graphics myCanvas) {
            myCanvas.SmoothingMode = SmoothingMode.AntiAlias;
            myCanvas.Clear(SystemColors.Control);

            if (RADIUS == 0) {
                if (ACTIVE_MODE == Modes.SolidFill) {
                    using (Brush myBrush = new SolidBrush(BACK_COLOR))
                        myCanvas.FillRectangle(myBrush, X, Y, WIDTH, HEIGHT);
                } else {
                    using (Brush myBrush = new LinearGradientBrush(new Rectangle(X, Y, WIDTH, HEIGHT), GR_START_COLOR, GR_END_COLOR, GR_ANGLE))
                        myCanvas.FillRectangle(myBrush, X, Y, WIDTH, HEIGHT);
                }

                if (THICKNESS > 0)
                    myCanvas.DrawRectangle(myPen, X, Y, WIDTH, HEIGHT);

                return;
            }

            Point p1 = new Point(X + RADIUS, Y),
                p2 = new Point(X + WIDTH - RADIUS, Y),
                p3 = new Point(X + WIDTH, Y + RADIUS),
                p4 = new Point(X + WIDTH, Y + HEIGHT - RADIUS),
                p5 = new Point(X + WIDTH - RADIUS, Y + HEIGHT),
                p6 = new Point(X + RADIUS, Y + HEIGHT),
                p7 = new Point(X, Y + HEIGHT - RADIUS),
                p8 = new Point(X, Y + RADIUS);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(X, Y, RADIUS * 2, RADIUS * 2, 180, 90);
            path.AddLine(p1, p2);
            path.AddArc(X + WIDTH - RADIUS * 2, Y, RADIUS * 2, RADIUS * 2, 270, 90);
            path.AddLine(p3, p4);
            path.AddArc(X + WIDTH - RADIUS * 2, Y + HEIGHT - RADIUS * 2, RADIUS * 2, RADIUS * 2, 0, 90);
            path.AddLine(p6, p5);
            path.AddArc(X, Y + HEIGHT - RADIUS * 2, RADIUS * 2, RADIUS * 2, 90, 90);
            path.AddLine(p8, p7);

            path.CloseFigure();

            if (ACTIVE_MODE == Modes.SolidFill) {
                using (Brush myBrush = new SolidBrush(BACK_COLOR))
                    myCanvas.FillPath(myBrush, path);
            } else {
                using (Brush myBrush = new LinearGradientBrush(new Rectangle(X, Y, WIDTH, HEIGHT), GR_START_COLOR, GR_END_COLOR, GR_ANGLE))
                    myCanvas.FillPath(myBrush, path);
            }

            if (THICKNESS > 0)
                myCanvas.DrawPath(myPen, path);

            myCanvas.Dispose();
        }

        private void trackBar_X_Scroll(object sender, EventArgs e) {
            X = Convert.ToInt16(trackBar_X.Value);
            label_X.Text = X.ToString();

            Invalidate();
        }

        private void trackBar_Y_Scroll(object sender, EventArgs e) {
            Y = (short) trackBar_Y.Value;
            label_Y.Text = Y.ToString();

            Invalidate();
        }

        private void trackBar_Width_Scroll(object sender, EventArgs e) {
            WIDTH = (short) trackBar_Width.Value;
            label_Width.Text = WIDTH.ToString();

            Invalidate();
        }

        private void trackBar_Height_Scroll(object sender, EventArgs e) {
            HEIGHT = (short) trackBar_Height.Value;
            label_Height.Text = HEIGHT.ToString();

            Invalidate();
        }

        private void trackBar_Radius_Scroll(object sender, EventArgs e) {
            RADIUS = (short) trackBar_Radius.Value;
            label_Radius.Text = RADIUS.ToString();

            Invalidate();
        }

        private void trackBar_Thickness_Scroll(object sender, EventArgs e) {
            THICKNESS = (byte) trackBar_Thickness.Value;
            label_Thickness.Text = THICKNESS.ToString();
            myPen.Width = THICKNESS;

            Invalidate();
        }

        private void btn_ChangeBorderColor_Click(object sender, EventArgs e) {
            colorDialog1.Color = BORDER_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                BORDER_COLOR = colorDialog1.Color;
                myPen.Color = colorDialog1.Color;
                Invalidate();
            }
        }

        private void radioButton_FillMode_CheckedChanged(object sender, EventArgs e) {
            if (!((RadioButton) sender).Checked)
                return;

            ACTIVE_MODE = (Modes) ((RadioButton) sender).Tag;
            
            if (ACTIVE_MODE == Modes.SolidFill) {
                groupBox_GradientFillOptions.Enabled = false;
                groupBox_SolidFillOptions.Enabled = true;
            } else {
                groupBox_GradientFillOptions.Enabled = true;
                groupBox_SolidFillOptions.Enabled = false;
            }

            Invalidate();
        }

        private void linkLabel_ChooseGRStartColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            colorDialog1.Color = GR_START_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                GR_START_COLOR = colorDialog1.Color;
                Invalidate();
            }
        }

        private void linkLabel_ChooseGrEndColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            colorDialog1.Color = GR_END_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                GR_END_COLOR = colorDialog1.Color;
                Invalidate();
            }
        }

        private void textBox_SetGRAngle_TextChanged(object sender, EventArgs e) {
            GR_ANGLE = string.IsNullOrEmpty(textBox_SetGRAngle.Text) ? (short) 0 : Convert.ToInt16(textBox_SetGRAngle.Text);
            Invalidate();
        }

        private void textBox_SetGRAngle_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void linkLabel_ChooseBackColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            colorDialog1.Color = BACK_COLOR;

            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                BACK_COLOR = colorDialog1.Color;
                Invalidate();
            }
        }
    }
}

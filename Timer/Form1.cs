using System;
using System.Windows.Forms;

namespace Timer {
    public partial class Form1 : Form {
        private sbyte _remainingSeconds, _remainingMinutes, _remainingHours;
        private bool _hasStarted = false;
        
        public Form1() {
            InitializeComponent();
        }

        private void ResetControls() {
            progressBar1.Value = 0;
            lbl_percentage.Text = "0.00%";

            txtBox_hours.Text = $"{Convert.ToSByte(txtBox_hours.Tag):d2}";
            txtBox_minutes.Text = $"{Convert.ToSByte(txtBox_minutes.Tag):d2}";
            txtBox_seconds.Text = $"{Convert.ToSByte(txtBox_seconds.Tag):d2}";

            if (notifyIcon_hide.Visible)
                lbl_trayTimer.Text = $"{txtBox_hours.Text}:{txtBox_minutes.Text}:{txtBox_seconds.Text}";

            txtBox_hours.Enabled = true;
            txtBox_minutes.Enabled = true;
            txtBox_seconds.Enabled = true;

            btn_start.Enabled = true;
            btn_pause.Enabled = false;

            if (notifyIcon_hide.Visible) {
                btn_trayStart.Enabled = true;
                btn_trayPause.Enabled = false;
            }
        }

        private bool SetUpControls_OnStart() {
            if (!_hasStarted) { //Setting everything up for the first time
                _hasStarted = true;

                if (txtBox_hours.Text.Equals(""))
                    txtBox_hours.Text = "00";
                else
                    txtBox_hours.Text = $"{Convert.ToSByte(txtBox_hours.Text):d2}";

                if (txtBox_minutes.Text.Equals(""))
                    txtBox_minutes.Text = "00";
                else
                    txtBox_minutes.Text = $"{Convert.ToSByte(txtBox_minutes.Text):d2}";

                if (txtBox_seconds.Text.Equals(""))
                    txtBox_seconds.Text = "00";
                else
                    txtBox_seconds.Text = $"{Convert.ToSByte(txtBox_seconds.Text):d2}";

                _remainingHours = Convert.ToSByte(txtBox_hours.Text);
                _remainingMinutes = Convert.ToSByte(txtBox_minutes.Text);
                _remainingSeconds = Convert.ToSByte(txtBox_seconds.Text);

                if (_remainingHours == 0 && _remainingMinutes == 0 && _remainingSeconds == 0) {
                    _hasStarted = false;
                    DisplayDurationErrorMessage();
                    return false;
                }

                txtBox_hours.Tag = _remainingHours;
                txtBox_minutes.Tag = _remainingMinutes;
                txtBox_seconds.Tag = _remainingSeconds;

                progressBar1.Maximum = (_remainingHours * 3600 + _remainingMinutes * 60 + _remainingSeconds) * 16;
            }

            txtBox_hours.Enabled = false;
            txtBox_minutes.Enabled = false;
            txtBox_seconds.Enabled = false;

            btn_start.Enabled = false;
            btn_reset.Enabled = false;
            btn_pause.Enabled = true;
            btn_hide.Enabled = true;

            if (notifyIcon_hide.Visible) {
                btn_trayStart.Enabled = false;
                btn_trayReset.Enabled = false;
                btn_trayPause.Enabled = true;
            }

            return true;
        }

        private void DisplayDurationErrorMessage() {
            MessageBox.Show("Please enter a duration.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_start_Click(object sender, EventArgs e) {
            if (txtBox_hours.Text.Equals("") && txtBox_minutes.Text.Equals("") && txtBox_seconds.Text.Equals("")) {
                DisplayDurationErrorMessage();
                return;
            }

            if (SetUpControls_OnStart())
                timer1.Start();
        }

        private void btn_reset_Click(object sender, EventArgs e) {
            _hasStarted = false;

            ResetControls();
        }

        private void notifyIcon_timerIsUp_BalloonTipClicked(object sender, EventArgs e) {
            notifyIcon_timerIsUp.Visible = false;
        }

        private void notifyIcon_timerIsUp_BalloonTipClosed(object sender, EventArgs e) {
            notifyIcon_timerIsUp.Visible = false;
        }

        private void btn_pause_Click(object sender, EventArgs e) {
            timer1.Stop();

            btn_pause.Enabled = false;
            btn_hide.Enabled = false;
            btn_reset.Enabled = true;
            btn_start.Enabled = true;

            if (notifyIcon_hide.Visible) {
                btn_trayPause.Enabled = false;
                btn_trayReset.Enabled = true;
                btn_trayStart.Enabled = true;
            }
        }

        private void btn_hide_Click(object sender, EventArgs e) {
            Hide();

            notifyIcon_hide.Visible = true;
            notifyIcon_hide.ShowBalloonTip(1000);
        }

        private void notifyIcon_hide_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();

            notifyIcon_hide.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            Show();

            notifyIcon_hide.Visible = false;
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            _remainingSeconds--;

            if (_remainingSeconds == -1) {
                _remainingSeconds = 59;
                _remainingMinutes--;

                if (_remainingMinutes == -1) {
                    _remainingMinutes = 59;
                    _remainingHours--;

                    if (_remainingHours == -1) {
                        TimerFinished();
                        
                        return;
                    }
                }
            }

            progressBar1.PerformStep();
            lbl_percentage.Text = $"{((float) progressBar1.Value / progressBar1.Maximum * 100):f2}%";
            txtBox_hours.Text = $"{_remainingHours:d2}";
            txtBox_minutes.Text = $"{_remainingMinutes:d2}";
            txtBox_seconds.Text = $"{_remainingSeconds:d2}";

            if (notifyIcon_hide.Visible)
                lbl_trayTimer.Text = $"{_remainingHours:d2}:{_remainingMinutes:d2}:{_remainingSeconds:d2}";
        }

        private void TimerFinished() {
            timer1.Stop(); //We must stop the timer before anything else
            Show();

            btn_pause.Enabled = false;
            btn_hide.Enabled = false;
            btn_reset.Enabled = true;
            //No need to modify the tray buttons here.

            notifyIcon_hide.Visible = false;
            notifyIcon_timerIsUp.Visible = true;
            notifyIcon_timerIsUp.ShowBalloonTip(1000);
        }
    }
}

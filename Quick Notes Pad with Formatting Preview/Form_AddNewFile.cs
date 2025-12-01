using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Notes_Pad_with_Formatting_Preview {
    public partial class Form_AddNewFile : Form {
        public string FileName { get; private set; }

        public Form_AddNewFile() {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) {
                errorProvider1.SetError(textBox1, "This field is required.");
                return;
            }

            int _lastPeriodPosition = textBox1.Text.LastIndexOf('.');

            if (_lastPeriodPosition.Equals(-1)) {
                FileName = textBox1.Text + ".txt";
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            if (!textBox1.Text.Substring(_lastPeriodPosition + 1).Equals("txt")) {
                errorProvider1.SetError(textBox1, "Invalid file extension.");
                return;
            }

            FileName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

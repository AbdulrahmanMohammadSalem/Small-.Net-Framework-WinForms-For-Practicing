using System;
using System.IO;
using System.Windows.Forms;

namespace Quick_Notes_Pad_with_Formatting_Preview {
    
    public partial class Form1 : Form {
        private const string FORM_TITLE = "Quick Notes Pad with Formatting Preview";
        private string _OpenedFileName = "Untitled file.txt";
        private string _OpenedFilePath = "";
        private bool _DoesOpenedFileExistOnDisk = false, _IsCurrentContentSavedOnDisk = false;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text = GetFormTitle(true);
        }

        private void txtBox_textInput_TextChanged(object sender, EventArgs e) {
            lbl_preview.Text = txtBox_textInput.Text;
            _IsCurrentContentSavedOnDisk = false;
            Text = GetFormTitle(true);
        }

        private void btn_changeFont_Click(object sender, EventArgs e) {
            fontDialog1.Font = lbl_preview.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                lbl_preview.Font = fontDialog1.Font;
        }

        private void fontDialog1_Apply(object sender, EventArgs e) {
            lbl_preview.Font = fontDialog1.Font;
        }

        private void btn_changeColor_Click(object sender, EventArgs e) {
            colorDialog1.Color = lbl_preview.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                lbl_preview.ForeColor = colorDialog1.Color;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                if (txtBox_textInput.Text.Equals("") || MessageBox.Show("The content in the textbox will be overwritten. Proceed?", FORM_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK) {
                    _DoesOpenedFileExistOnDisk = true;
                    _IsCurrentContentSavedOnDisk = true;
                    _OpenedFilePath = openFileDialog1.FileName;
                    _OpenedFileName = GetFileNameFromPath(openFileDialog1.FileName);

                    txtBox_textInput.Text = File.ReadAllText(openFileDialog1.FileName);
                    txtBox_textInput.SelectionStart = txtBox_textInput.Text.Length;
                    Text = GetFormTitle();
                }
            }
        }

        private string GetFileNameFromPath(string filePath) {
            return filePath.Substring(filePath.LastIndexOf('\\') + 1);
        }

        private string GetFormTitle(bool insertAstrisk = false) {
            if (insertAstrisk)
                return $"{_OpenedFileName}* - {FORM_TITLE}";

            return $"{_OpenedFileName} - {FORM_TITLE}";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_AddNewFile _frm_addNewFile = new Form_AddNewFile();

            if (_frm_addNewFile.ShowDialog() == DialogResult.OK) {
                if (!_IsCurrentContentSavedOnDisk) {
                    DialogResult _result = MessageBox.Show("The currently opened file is not saved. Do you want to save it before creating the new file?", FORM_TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (_result == DialogResult.Cancel)
                        return;

                    if (_result == DialogResult.Yes)
                        saveToolStripMenuItem_Click(saveToolStripMenuItem, EventArgs.Empty);
                }

                _OpenedFileName = _frm_addNewFile.FileName;
                _DoesOpenedFileExistOnDisk = false;
                txtBox_textInput.Text = "";
                Text = GetFormTitle(true);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!_DoesOpenedFileExistOnDisk) {
                saveAsToolStripMenuItem_Click(saveAsToolStripMenuItem, EventArgs.Empty);
                return;
            }

            File.WriteAllText(_OpenedFilePath, txtBox_textInput.Text);
            Text = GetFormTitle();
            _IsCurrentContentSavedOnDisk = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            if (txtBox_textInput.Text.Equals(""))
                return;

            txtBox_textInput.Text = "";
            _IsCurrentContentSavedOnDisk = false;
            Text = GetFormTitle(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = _OpenedFileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                _OpenedFilePath = saveFileDialog1.FileName;
                _OpenedFileName = GetFileNameFromPath(_OpenedFilePath);
                _DoesOpenedFileExistOnDisk = true;
                _IsCurrentContentSavedOnDisk = true;

                File.WriteAllText(_OpenedFilePath, txtBox_textInput.Text);
                Text = GetFormTitle();
            }
        }
    }
}

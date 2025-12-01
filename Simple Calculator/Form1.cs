using System;
using System.Linq;
using System.Windows.Forms;

namespace Simple_Calculator {
    public partial class Form1 : Form {
        private enum OperationTypes : byte {
            Addition, Subtraction, Multiplication, Division, Unset
        }

        private double _firstNumber = 0;
        private OperationTypes _operationType = OperationTypes.Unset;
        private bool _textUpdatedAfterChoosingOperation = true;

        public Form1() {
            InitializeComponent();
        }

        private void ResetForm() {
            lbl_display.Text = "";
            lbl_operation.Text = "";
            _operationType = OperationTypes.Unset;
            _textUpdatedAfterChoosingOperation = true;
        }

        private void UpdateDisplayLabel(string text) {
            lbl_display.Text += text;
            _textUpdatedAfterChoosingOperation = true;
        }

        private void btn_Display_Click(object sender, EventArgs e) {
            if (_operationType == OperationTypes.Unset || _textUpdatedAfterChoosingOperation) {
                UpdateDisplayLabel(((Button) sender).Tag.ToString());
                return;
            }

            _firstNumber = Convert.ToDouble(lbl_display.Text);
            lbl_display.Text = ((Button) sender).Tag.ToString();
            _textUpdatedAfterChoosingOperation = true;
        }

        private void btn_decimalPoint_Click(object sender, EventArgs e) {
            if (_operationType == OperationTypes.Unset || _textUpdatedAfterChoosingOperation) {
                if (lbl_display.Text.Equals("")) {
                    lbl_display.Text = "0.";
                    _textUpdatedAfterChoosingOperation = true;
                    return;
                }
                else if (lbl_display.Text.Contains('.'))
                    return;

                UpdateDisplayLabel(".");
                return;
            }

            _firstNumber = Convert.ToDouble(lbl_display.Text);
            lbl_display.Text = "0.";
            _textUpdatedAfterChoosingOperation = true;
        }

        private void btn_operation_Click(object sender, EventArgs e) {
            if (lbl_display.Text.Equals(""))
                return;

            if (_operationType != OperationTypes.Unset && _textUpdatedAfterChoosingOperation)
                btn_evaluate_Click(btn_evaluate, EventArgs.Empty);

            lbl_operation.Text = ((Button) sender).Tag.ToString();
            _operationType = GetOperationTypeEnumValue(Convert.ToChar(lbl_operation.Text));
            _textUpdatedAfterChoosingOperation = false;
        }

        private OperationTypes GetOperationTypeEnumValue(char operationChar) {
            switch (operationChar) {
                case '+': return OperationTypes.Addition;
                case '-': return OperationTypes.Subtraction;
                case '*': return OperationTypes.Multiplication;
                case '/': return OperationTypes.Division;
                default: throw new Exception("Unknown operation type");
            }
        }

        private void btn_ac_Click(object sender, EventArgs e) {
            ResetForm();
        }

        private void btn_evaluate_Click(object sender, EventArgs e) {
            if (lbl_display.Text.Equals(""))
                return;

            if (_operationType != OperationTypes.Unset) {
                lbl_display.Text = Calculate(_firstNumber, Convert.ToDouble(lbl_display.Text), _operationType).ToString();
                lbl_operation.Text = "";
                _operationType = OperationTypes.Unset;
            }
        }

        private double Calculate(double num1, double num2, OperationTypes opType) {
            switch (opType) {
                case OperationTypes.Addition: return num1 + num2;
                case OperationTypes.Subtraction: return num1 - num2;
                case OperationTypes.Multiplication: return num1 * num2;
                case OperationTypes.Division: return num1 / num2;
                default: throw new Exception("Invalid operation type");
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e) {
            if (lbl_display.Text.Equals(""))
                return;
            
            _operationType = OperationTypes.Unset;
            lbl_operation.Text = "";
            lbl_display.Text = Math.Sqrt(Convert.ToDouble(lbl_display.Text)).ToString();
            
        }

        private void btn_percent_Click(object sender, EventArgs e) {
            if (lbl_display.Text.Equals(""))
                return;

            _operationType = OperationTypes.Unset;
            lbl_operation.Text = "";
            lbl_display.Text = (Convert.ToDouble(lbl_display.Text) * 0.01).ToString();
        }

        private void btn_zero_Click(object sender, EventArgs e) {
            if (lbl_display.Text.Equals("0"))
                return;

            btn_Display_Click(btn_zero, EventArgs.Empty);
        }
    }
}

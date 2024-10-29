using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_calculator
{
    public partial class CalcForm : Form
    {

        private int _currentOperation;
        private decimal _number1;
        private decimal _number2;
        public CalcForm()
        {
            InitializeComponent();
            this.operationBox.SelectedItem = this.operationBox.Items[0];
            _currentOperation = this.operationBox.SelectedIndex;
            _number1 = 0.0M;
            _number2 = 0.0M;
            this.inputNumber1.Text = "0.0";
            this.inputNumber2.Text = "0.0";
        }
        private int checkFormat(string input)
        {
            string stringNumber = input;
            stringNumber = stringNumber.Replace('.', ',');
            try
            {
                Convert.ToDecimal(stringNumber, new System.Globalization.CultureInfo("ru-RU"));
                return 1;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input format!\nChange your numbers!");
                return 0;
            }
            catch (OverflowException ex)
            {
                return 0;
            }
        }

        private void inputNumber1_Leave(object sender, EventArgs e)
        {
            string stringNumber = this.inputNumber1.Text;
            stringNumber = stringNumber.Replace('.', ',');
            try
            {
                _number1 = Convert.ToDecimal(stringNumber, new System.Globalization.CultureInfo("ru-RU"));
            }
            catch (FormatException ex)
            {
                this.resultBox.Text = String.Empty;
                this.wrongFormatLabel1.Visible = true;
                _number1 = 0.0M;
            }
            catch (OverflowException ex)
            {
                this.resultBox.Text = String.Empty;
                this.outOfRangeLabel1.Visible = true;
                _number2 = 0.0M;
            }
        }

        private void inputNumber2_Leave(object sender, EventArgs e)
        {
            string stringNumber = this.inputNumber2.Text;
            stringNumber = stringNumber.Replace('.', ',');
            try
            {
                _number2 = Convert.ToDecimal(stringNumber, new System.Globalization.CultureInfo("ru-RU"));
            }
            catch (FormatException ex)
            {
                this.resultBox.Text = String.Empty;
                this.wrongFormatLabel2.Visible = true;
                _number2 = 0.0M;
            }
            catch (OverflowException ex)
            {
                this.resultBox.Text = String.Empty;
                this.outOfRangeLabel2.Visible = true;
                _number2 = 0.0M;
            }
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            _currentOperation = this.operationBox.SelectedIndex;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            if (checkFormat(this.inputNumber1.Text) != 1 ||
                checkFormat(this.inputNumber2.Text) != 1)
            {
                return;
            }

            decimal result;
            try
            {
                switch (_currentOperation)
                {
                    case 0:
                        result = _number1 + _number2;
                        result = Math.Round(result, 6);
                        this.resultBox.Text = result.ToString("#,0.######", _outputFormatInfo);
                        break;
                    case 1:
                        result = _number1 - _number2;
                        result = Math.Round(result, 6);
                        this.resultBox.Text = result.ToString("#,0.######", _outputFormatInfo);
                        break;
                    case 2:
                        result = _number1 * _number2;
                        result = Math.Round(result, 6);
                        this.resultBox.Text = result.ToString("#,0.######", _outputFormatInfo);
                        break;
                    case 3:
                        result = _number1 / _number2;
                        result = Math.Round(result, 6);
                        this.resultBox.Text = result.ToString("#,0.######", _outputFormatInfo);
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Calculation error!\nDivision by zero!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Result number is out of reachable range!\nImpossible to complete operation!");
            }
        }

        private void inputNumber1_Enter(object sender, EventArgs e)
        {
            this.wrongFormatLabel1.Visible = false;
            this.outOfRangeLabel1.Visible = false;
        }

        private void inputNumber2_Enter(object sender, EventArgs e)
        {
            this.wrongFormatLabel2.Visible = false;
            this.outOfRangeLabel2.Visible = false;
        }

        private readonly NumberFormatInfo _outputFormatInfo = new NumberFormatInfo
        {
            NumberGroupSeparator = " ",
            NumberDecimalDigits = 6,
            NumberDecimalSeparator = "."
        };
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private static bool IsValidFormat(string input)
        {
            string pattern = @"^\d{1,3}( \d{3})*(\,\d+)?$";
            return Regex.IsMatch(input, pattern);
        }
        private decimal? TryParseNumber(Control control, string input)
        {
            string stringNumber = input.Replace('.', ',').TrimEnd();
            decimal number = 0.0M;
            try
            {
                if (stringNumber.Contains(" "))
                    throw new FormatException("");

                number = decimal.Parse(stringNumber);
                return number;
            }
            catch (FormatException ex)
            {
                try
                {
                    if (!IsValidFormat(stringNumber))
                        throw new FormatException(ex.Message);

                    number = decimal.Parse(stringNumber, _inputFormatInfo);
                    return number;
                }
                catch (FormatException)
                {
                    this.resultBox.Text = String.Empty;

                    if (control == this.inputNumber1)
                        this.wrongFormatLabel1.Visible = true; 
                    
                    else if (control == this.inputNumber2)
                        this.wrongFormatLabel2.Visible = true;

                    else
                    {
                        MessageBox.Show("Wrong input format!\nChange your numbers!");
                    }
                    return null;
                }
            }
            catch (OverflowException ex)
            {
                this.resultBox.Text = String.Empty;

                if (control == this.inputNumber1)
                    this.outOfRangeLabel1.Visible = true;
                
                else if (control == this.inputNumber2)
                    this.outOfRangeLabel2.Visible = true;

                else
                {
                    MessageBox.Show("Number are out of range!\nChange your numbers!");
                }
                return null;
            }
        }

        private void inputNumber1_Leave(object sender, EventArgs e)
        {
            decimal? number = TryParseNumber(this.inputNumber1, this.inputNumber1.Text);
            if (number != null)
            {
                _number1 = number.Value;
            }
            else _number1 = 0.0M;
        }

        private void inputNumber2_Leave(object sender, EventArgs e)
        {
            decimal? number = TryParseNumber(this.inputNumber2, this.inputNumber2.Text);
            if (number != null)
            {
                _number2 = number.Value;
            }
            else _number2 = 0.0M;
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            _currentOperation = this.operationBox.SelectedIndex;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (TryParseNumber(this.equalsButton, this.inputNumber1.Text) == null ||
                TryParseNumber(this.equalsButton, this.inputNumber2.Text) == null)
                return;

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

        private readonly IFormatProvider _inputFormatInfo = new NumberFormatInfo
        {
            NumberGroupSeparator = " ",
            NumberDecimalSeparator = ","
        };
    }
}

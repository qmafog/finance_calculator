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

        private int _currentOperation1;
        private int _currentOperation2;
        private int _currentOperation3;
        private decimal _number1;
        private decimal _number2;
        private decimal _number3;
        private decimal _number4;
        public CalcForm()
        {
            InitializeComponent();
            this.operationBox.SelectedItem = this.operationBox.Items[0];
            _currentOperation1 = this.operationBox.SelectedIndex;
            this.operationBox2.SelectedItem = this.operationBox2.Items[0];
            _currentOperation2 = this.operationBox.SelectedIndex;
            this.operationBox3.SelectedItem = this.operationBox3.Items[0];
            _currentOperation3 = this.operationBox.SelectedIndex;
            _number1 = 0.0M;
            _number2 = 0.0M;
            _number3 = 0.0M;
            _number4 = 0.0M;
            this.inputNumber1.Text = "0.0";
            this.inputNumber2.Text = "0.0";
            this.inputNumber3.Text = "0.0";
            this.inputNumber4.Text = "0.0";
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

                    else if (control == this.inputNumber3)
                        this.wrongFormatLabel3.Visible = true;

                    else if (control == this.inputNumber4)
                        this.wrongFormatLabel4.Visible = true;

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

                else if (control == this.inputNumber3)
                    this.outOfRangeLabel3.Visible = true;

                else if (control == this.inputNumber4)
                    this.outOfRangeLabel4.Visible = true;

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

        private void inputNumber3_Leave(object sender, EventArgs e)
        {
            decimal? number = TryParseNumber(this.inputNumber3, this.inputNumber3.Text);
            if (number != null)
            {
                _number3 = number.Value;
            }
            else _number3 = 0.0M;
        }

        private void inputNumber4_Leave(object sender, EventArgs e)
        {
            decimal? number = TryParseNumber(this.inputNumber4, this.inputNumber4.Text);
            if (number != null)
            {
                _number4 = number.Value;
            }
            else _number4 = 0.0M;
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            _currentOperation1 = this.operationBox.SelectedIndex;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (TryParseNumber(this.equalsButton, this.inputNumber1.Text) == null ||
                TryParseNumber(this.equalsButton, this.inputNumber3.Text) == null ||
                TryParseNumber(this.equalsButton, this.inputNumber4.Text) == null ||
                TryParseNumber(this.equalsButton, this.inputNumber2.Text) == null)
                return;

            decimal result = 0.0M, 
                    middleAction = 0.0M,  
                    secondAction = 0.0M;

            try
            {
                middleAction = doOperation(_currentOperation2, _number2, _number3);

                if (!( _currentOperation1 == 2 || _currentOperation1 == 3 ) &&
                     ( _currentOperation3 == 2 || _currentOperation3 == 3 ))
                {
                    secondAction = doOperation(_currentOperation3, middleAction, _number4);
                    result = doOperation(_currentOperation1, _number1, secondAction);
                }
                else
                {
                    secondAction = doOperation(_currentOperation1, _number1, middleAction);
                    result = doOperation(_currentOperation3, secondAction, _number4);
                }

                this.resultBox.Text = result.ToString("#,0.##########", _outputFormatInfo);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Calculation error!\nDivision by zero!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Middleware calculation result is out of reachable range!\nImpossible to complete operation!");
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
            NumberDecimalDigits = 10,
            NumberDecimalSeparator = "."
        };

        private readonly IFormatProvider _inputFormatInfo = new NumberFormatInfo
        {
            NumberGroupSeparator = " ",
            NumberDecimalSeparator = ","
        };

        private void operationBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            _currentOperation2 = this.operationBox2.SelectedIndex;
        }

        private void operationBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultBox.Text = String.Empty;
            _currentOperation3 = this.operationBox3.SelectedIndex;
        }

        private void inputNumber3_Enter(object sender, EventArgs e)
        {
            this.wrongFormatLabel3.Visible = false;
            this.outOfRangeLabel3.Visible = false;
        }

        private void inputNumber4_Enter(object sender, EventArgs e)
        {
            this.wrongFormatLabel4.Visible = false;
            this.outOfRangeLabel4.Visible = false;
        }

        static decimal doOperation(int operation, decimal num1, decimal num2)
        {
            decimal result = 0.0M;

            switch (operation)
            {
                case 0:
                    result = num1 + num2;             
                    break;
                case 1:
                    result = num1 - num2;
                    break;
                case 2:
                    result = num1 * num2;
                    break;
                case 3:
                    result = num1 / num2;
                    break;
            }

            result = Math.Round(result, 10);
            return result;
        }

    }
}

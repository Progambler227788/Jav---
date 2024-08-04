using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeDigitButtons();
            numUpDownBits_ValueChanged(null, null);
            radioBinary.Checked = false;
            radioBinary.Checked = true;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked)
                return;
            txtBinary.Clear();
            txtDenary.Clear();
            txtHexadecimal.Clear();
            bool binary = radioButton == radioBinary;
            bool denary = radioButton == radioDenary;
            bool hexadecimal = radioButton == radioHexadecimal;
            txtBinary.Enabled = binary;
            txtDenary.Enabled = denary;
            txtHexadecimal.Enabled = hexadecimal;
            numUpDownBits.Enabled = binary;
            btnLeftShift.Enabled = binary;
            btnRightShift.Enabled = binary;
            InitializeDigitButtons();
            if (binary)
            {
                zero.Enabled = true;
                one.Enabled = true;
            }
            else if (denary)
            {
                zero.Enabled = true;
                one.Enabled = true;
                two.Enabled = true;
                three.Enabled = true;
                four.Enabled = true;
                five.Enabled = true;
                six.Enabled = true;
                seven.Enabled = true;
                eight.Enabled = true;
                nine.Enabled = true;
            }
            else if (hexadecimal)
            {
                zero.Enabled = true;
                one.Enabled = true;
                two.Enabled = true;
                three.Enabled = true;
                four.Enabled = true;
                five.Enabled = true;
                six.Enabled = true;
                seven.Enabled = true;
                eight.Enabled = true;
                nine.Enabled = true;
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                E.Enabled = true;
                F.Enabled = true;
            }
        }

        private void btnLeftShift_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                if (txtBinary.Text[0] == '1')
                    ErrorMessage.Text = "Overflow detected!";
                else
                    ErrorMessage.Text = "";
                txtBinary.Text = txtBinary.Text.Substring(1) + "0";
            }
            PerformConversions();
        }

        private void btnRightShift_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                if (txtBinary.Text[txtBinary.Text.Length - 1] == '1')
                    ErrorMessage.Text = "Underflow detected!";
                else
                    ErrorMessage.Text = "";
                txtBinary.Text = "0" + txtBinary.Text.Substring(0, txtBinary.Text.Length - 1);
            }
            PerformConversions();
        }

        private void numUpDownBits_ValueChanged(object sender, EventArgs e)
        {
            int totalWidth = (int)numUpDownBits.Value;
            if (!string.IsNullOrEmpty(txtBinary.Text))
            {
                if (txtBinary.Text.Length > totalWidth)
                    txtBinary.Text = txtBinary.Text.Substring(txtBinary.Text.Length - totalWidth);
                else if (txtBinary.Text.Length < totalWidth)
                    txtBinary.Text = txtBinary.Text.PadLeft(totalWidth, '0');
            }
            PerformConversions();
        }

        private void PerformConversionsTextChanged(object sender, EventArgs e)
        {
            PerformConversions();

        } 
        private void txtDenary_TextChanged(object sender, EventArgs e)
        {
            PerformConversions();

        }

        private void PerformConversions()
        {
            if (radioBinary.Checked && !string.IsNullOrEmpty(txtBinary.Text))
            {
                if (!IsBinary(txtBinary.Text))
                {
                    txtBinary.Clear();
                    ErrorMessage.Text = "Invalid binary Number! (only 0,1 allowed)";
                }
                else
                {
                    try
                    {
                        txtDenary.Text = Convert.ToInt64(txtBinary.Text, 2).ToString();
                    }
                    catch (FormatException ex)
                    {
                        txtDenary.Text = "Invalid";
                    }
                    try
                    {
                        txtHexadecimal.Text = (string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text)).ToString("X");
                    }
                    catch (FormatException ex)
                    {
                        txtHexadecimal.Text = "Invalid";
                    }
                }
            }
            else if (radioDenary.Checked && !string.IsNullOrEmpty(txtDenary.Text))
            {
                if (!IsDenary(txtDenary.Text))
                {
                    txtDenary.Clear();
                    ErrorMessage.Text = "Invalid denary number!(0-9 allowed)";
                }
                else
                {
                    try
                    {
                        txtBinary.Text = Convert.ToString(long.Parse(txtDenary.Text), 2);
                    }
                    catch (FormatException ex)
                    {
                        txtBinary.Text = "Invalid";
                    }
                    try
                    {
                        txtHexadecimal.Text = (string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text)).ToString("X");
                    }
                    catch (FormatException ex)
                    {
                        txtHexadecimal.Text = "Invalid";
                    }
                }
            }
            else
            {
                if (!radioHexadecimal.Checked || string.IsNullOrEmpty(txtHexadecimal.Text))
                    return;
                if (!IsHexadecimal(txtHexadecimal.Text))
                {
                    txtHexadecimal.Clear();
                    ErrorMessage.Text = "Invalid hex number!(0-9, A-F allowed)";
                }
                else
                {
                    try
                    {
                        txtDenary.Text = Convert.ToInt64(txtHexadecimal.Text, 16).ToString();
                    }
                    catch (FormatException ex)
                    {
                        txtDenary.Text = "Invalid";
                    }
                    try
                    {
                        txtBinary.Text = Convert.ToString(string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text), 2);
                    }
                    catch (FormatException ex)
                    {
                        txtBinary.Text = "Invalid";
                    }
                }
            }
        }

        private void PerformConversions(string inputValue)
        {
            if (radioBinary.Checked && inputValue != "0" && inputValue != "1")
                ErrorMessage.Text = "Invalid input for binary conversion! Only 0 and 1 are allowed.";
            else if (radioHexadecimal.Checked && !Regex.IsMatch(inputValue, "^[0-9A-Fa-f]$"))
                ErrorMessage.Text = "Invalid input for hexadecimal conversion! Only digits 0-9 and letters A-F are allowed.";
            else if (radioBinary.Checked)
            {
                txtBinary.Text += inputValue;
                try
                {
                    txtDenary.Text = Convert.ToInt64(txtBinary.Text, 2).ToString();
                }
                catch (FormatException ex)
                {
                    txtDenary.Text = "Invalid";
                }
                try
                {
                    txtHexadecimal.Text = (string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text)).ToString("X");
                }
                catch (FormatException ex)
                {
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else if (radioDenary.Checked)
            {
                txtDenary.Text += inputValue;
                try
                {
                    txtBinary.Text = Convert.ToString(long.Parse(txtDenary.Text), 2);
                }
                catch (FormatException ex)
                {
                    txtBinary.Text = "Invalid";
                }
                try
                {
                    txtHexadecimal.Text = (string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text)).ToString("X");
                }
                catch (FormatException ex)
                {
                    txtHexadecimal.Text = "Invalid";
                }
            }
            else
            {
                if (!radioHexadecimal.Checked)
                    return;
                txtHexadecimal.Text += inputValue;
                try
                {
                    txtDenary.Text = Convert.ToInt64(txtHexadecimal.Text, 16).ToString();
                }
                catch (FormatException ex)
                {
                    txtDenary.Text = "Invalid";
                }
                try
                {
                    txtBinary.Text = Convert.ToString(string.IsNullOrEmpty(txtDenary.Text) ? 0 : long.Parse(txtDenary.Text), 2);
                }
                catch (FormatException ex)
                {
                    txtBinary.Text = "Invalid";
                }
            }
        }

        private bool IsBinary(string input)
        {
            foreach (char ch in input)
            {
                if (ch != '0' && ch != '1')
                    return false;
            }
            return true;
        }

        private bool IsDenary(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool IsHexadecimal(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && !(c >= 'A' && c <= 'F') && !(c >= 'a' && c <= 'f'))
                    return false;
            }
            return true;
        }

        private void txtDenary_TextChanged_1(object sender, EventArgs e) 
        {
            PerformConversions(); 
        }

        private void txtDenary_TextChanged_2(object sender, EventArgs e)
        {
            PerformConversions();
        }

        private void txtHexadecimal_TextChanged(object sender, EventArgs e)
        {
            PerformConversions();
        }

        private void InitializeDigitButtons()
        {
            zero.Enabled = false;
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBinary.Enabled = true;
            txtDenary.Enabled = false;
            txtHexadecimal.Enabled = false;
            numUpDownBits.Enabled = true;
            btnLeftShift.Enabled = true;
            btnRightShift.Enabled = true;
        }

        private void DigitButtons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (radioBinary.Checked)
            {
                if ((Decimal)txtBinary.Text.Length >= numUpDownBits.Value)
                {
                    ErrorMessage.Text = "Use digits Count to increase/decrease length";
                    return;
                }
            }
            else if (radioDenary.Checked)
            {
                if (txtDenary.Text.Length >= 8)
                {
                    ErrorMessage.Text = "Max Length Allowed is 8 Digits";
                    return;
                }
            }
            else if (radioHexadecimal.Checked && txtHexadecimal.Text.Length >= 8)
            {
                ErrorMessage.Text = "Max Length Allowed is 8 Digits";
                return;
            }
            PerformConversions(button.Text);
        }

        
        private void txtBinary_KeyDown(object sender, KeyEventArgs e)
        {
            ErrorMessage.Text = "";
            if ((Decimal)txtBinary.Text.Length >= numUpDownBits.Value && !e.Control && !e.Alt && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "Use digits Count to increase/decrease length";
            }
            else
            {
                if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.Control || e.Alt || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                    return;
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "Only 0,1 allowed in Binary";
            }
        }

        private void txtDenary_KeyDown(object sender, KeyEventArgs e)
        {
            ErrorMessage.Text = "";
            if (txtDenary.Text.Length >= 8 && !e.Control && !e.Alt && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "Max Length allowed is 8 digits";
            }
            else
            {
                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.Control || e.Alt || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                    return;
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "only 0-9 allowed";
            }
        }

        private void txtHexadecimal_KeyDown(object sender, KeyEventArgs e)
        {
            // Clear any previous error message
            ErrorMessage.Text = "";

            // Check if the length exceeds the maximum allowed length
            if (txtHexadecimal.Text.Length >= 8 &&
                !e.Control && !e.Alt &&
                e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete &&
                e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "Max Length allowed is 8 digits";
                return;
            }

            // Check if the key pressed is a valid hexadecimal character or a control key
            bool isDigit = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isHexLetter = (e.KeyCode >= Keys.A && e.KeyCode <= Keys.F);

            if (!isDigit && !isHexLetter &&
                !e.Control && !e.Alt &&
                e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete &&
                e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                e.SuppressKeyPress = true;
                ErrorMessage.Text = "Only 0-9, A-F allowed";
                return;
            }

        }

        private void txtBinary_Enter(object sender, EventArgs e) => txtBinary.Text = "";

        private void txtBinary_Leave(object sender, EventArgs e)
        {
        }

    }
}

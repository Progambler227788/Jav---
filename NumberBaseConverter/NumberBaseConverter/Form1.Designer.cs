using System.Drawing;
using System.Windows.Forms;

namespace NumberBaseConverter
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblDenary = new System.Windows.Forms.Label();
            this.lblHexadecimal = new System.Windows.Forms.Label();
            this.txtHexadecimal = new System.Windows.Forms.TextBox();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.numUpDownBits = new System.Windows.Forms.NumericUpDown();
            this.lblBits = new System.Windows.Forms.Label();
            this.radioBinary = new System.Windows.Forms.RadioButton();
            this.radioDenary = new System.Windows.Forms.RadioButton();
            this.radioHexadecimal = new System.Windows.Forms.RadioButton();
            this.txtDenary = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(134, 134);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(281, 26);
            this.txtBinary.TabIndex = 0;
            this.txtBinary.Text = "00000000";
            this.txtBinary.TextChanged += new System.EventHandler(this.PerformConversionsTextChanged);
            this.txtBinary.Enter += new System.EventHandler(this.txtBinary_Enter);
            this.txtBinary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBinary_KeyDown);
            this.txtBinary.Leave += new System.EventHandler(this.txtBinary_Leave);
            // 
            // lblBinary
            // 
            this.lblBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.Location = new System.Drawing.Point(11, 138);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(115, 24);
            this.lblBinary.TabIndex = 1;
            this.lblBinary.Text = "Binary";
            this.lblBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDenary
            // 
            this.lblDenary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenary.Location = new System.Drawing.Point(11, 186);
            this.lblDenary.Name = "lblDenary";
            this.lblDenary.Size = new System.Drawing.Size(115, 25);
            this.lblDenary.TabIndex = 3;
            this.lblDenary.Text = "Denary";
            this.lblDenary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHexadecimal
            // 
            this.lblHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexadecimal.Location = new System.Drawing.Point(11, 235);
            this.lblHexadecimal.Name = "lblHexadecimal";
            this.lblHexadecimal.Size = new System.Drawing.Size(116, 24);
            this.lblHexadecimal.TabIndex = 5;
            this.lblHexadecimal.Text = "Hexadecimal";
            this.lblHexadecimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Location = new System.Drawing.Point(134, 231);
            this.txtHexadecimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.Size = new System.Drawing.Size(281, 26);
            this.txtHexadecimal.TabIndex = 4;
            this.txtHexadecimal.TextChanged += new System.EventHandler(this.txtHexadecimal_TextChanged);
            this.txtHexadecimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHexadecimal_KeyDown);
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Location = new System.Drawing.Point(133, 316);
            this.btnLeftShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(112, 38);
            this.btnLeftShift.TabIndex = 6;
            this.btnLeftShift.Text = "Left Shift";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            this.btnLeftShift.Click += new System.EventHandler(this.btnLeftShift_Click);
            // 
            // btnRightShift
            // 
            this.btnRightShift.Location = new System.Drawing.Point(302, 316);
            this.btnRightShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(112, 38);
            this.btnRightShift.TabIndex = 7;
            this.btnRightShift.Text = "Right Shift";
            this.btnRightShift.UseVisualStyleBackColor = true;
            this.btnRightShift.Click += new System.EventHandler(this.btnRightShift_Click);
            // 
            // numUpDownBits
            // 
            this.numUpDownBits.Location = new System.Drawing.Point(133, 275);
            this.numUpDownBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUpDownBits.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numUpDownBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBits.Name = "numUpDownBits";
            this.numUpDownBits.Size = new System.Drawing.Size(112, 26);
            this.numUpDownBits.TabIndex = 8;
            this.numUpDownBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownBits.ValueChanged += new System.EventHandler(this.numUpDownBits_ValueChanged);
            // 
            // lblBits
            // 
            this.lblBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBits.Location = new System.Drawing.Point(11, 278);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(115, 25);
            this.lblBits.TabIndex = 9;
            this.lblBits.Text = "Bits Count";
            this.lblBits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioBinary
            // 
            this.radioBinary.AutoSize = true;
            this.radioBinary.Checked = true;
            this.radioBinary.Location = new System.Drawing.Point(86, 68);
            this.radioBinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBinary.Name = "radioBinary";
            this.radioBinary.Size = new System.Drawing.Size(78, 24);
            this.radioBinary.TabIndex = 10;
            this.radioBinary.TabStop = true;
            this.radioBinary.Text = "Binary";
            this.radioBinary.UseVisualStyleBackColor = true;
            this.radioBinary.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioDenary
            // 
            this.radioDenary.AutoSize = true;
            this.radioDenary.Location = new System.Drawing.Point(170, 68);
            this.radioDenary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioDenary.Name = "radioDenary";
            this.radioDenary.Size = new System.Drawing.Size(85, 24);
            this.radioDenary.TabIndex = 11;
            this.radioDenary.Text = "Denary";
            this.radioDenary.UseVisualStyleBackColor = true;
            this.radioDenary.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioHexadecimal
            // 
            this.radioHexadecimal.AutoSize = true;
            this.radioHexadecimal.Location = new System.Drawing.Point(263, 68);
            this.radioHexadecimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioHexadecimal.Name = "radioHexadecimal";
            this.radioHexadecimal.Size = new System.Drawing.Size(125, 24);
            this.radioHexadecimal.TabIndex = 12;
            this.radioHexadecimal.Text = "Hexadecimal";
            this.radioHexadecimal.UseVisualStyleBackColor = true;
            this.radioHexadecimal.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // txtDenary
            // 
            this.txtDenary.Location = new System.Drawing.Point(133, 184);
            this.txtDenary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDenary.Name = "txtDenary";
            this.txtDenary.Size = new System.Drawing.Size(281, 26);
            this.txtDenary.TabIndex = 13;
            this.txtDenary.TextChanged += new System.EventHandler(this.txtDenary_TextChanged_2);
            this.txtDenary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDenary_KeyDown);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(92, 376);
            this.zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(35, 41);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(254, 376);
            this.four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(35, 41);
            this.four.TabIndex = 15;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(295, 376);
            this.five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(35, 41);
            this.five.TabIndex = 16;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(335, 376);
            this.six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(35, 41);
            this.six.TabIndex = 17;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(376, 376);
            this.seven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(35, 41);
            this.seven.TabIndex = 18;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(92, 422);
            this.eight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(35, 39);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(214, 376);
            this.three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(35, 41);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(173, 376);
            this.two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(35, 41);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(133, 376);
            this.one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(35, 41);
            this.one.TabIndex = 22;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(133, 422);
            this.nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(35, 39);
            this.nine.TabIndex = 23;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(376, 422);
            this.F.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(35, 39);
            this.F.TabIndex = 25;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(335, 422);
            this.E.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(35, 39);
            this.E.TabIndex = 26;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(295, 422);
            this.D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(35, 39);
            this.D.TabIndex = 27;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(254, 422);
            this.C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(35, 39);
            this.C.TabIndex = 28;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(214, 422);
            this.B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(35, 39);
            this.B.TabIndex = 29;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(173, 422);
            this.A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(35, 39);
            this.A.TabIndex = 30;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.DigitButtons_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(63, 96);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(352, 29);
            this.ErrorMessage.TabIndex = 31;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Number Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(252, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 51);
            this.label2.TabIndex = 33;
            this.label2.Text = "for Denary and Hax, Max Length is 8";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.E);
            this.Controls.Add(this.F);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.txtDenary);
            this.Controls.Add(this.radioHexadecimal);
            this.Controls.Add(this.radioDenary);
            this.Controls.Add(this.radioBinary);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.numUpDownBits);
            this.Controls.Add(this.btnRightShift);
            this.Controls.Add(this.btnLeftShift);
            this.Controls.Add(this.lblHexadecimal);
            this.Controls.Add(this.txtHexadecimal);
            this.Controls.Add(this.lblDenary);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.txtBinary);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Number Base Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblDenary;
        private System.Windows.Forms.Label lblHexadecimal;
        private System.Windows.Forms.TextBox txtHexadecimal;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.NumericUpDown numUpDownBits;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.RadioButton radioBinary;
        private System.Windows.Forms.RadioButton radioDenary;
        private System.Windows.Forms.RadioButton radioHexadecimal;
        private TextBox txtDenary;
        private Button zero;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button three;
        private Button two;
        private Button one;
        private Button nine;
        private Button F;
        private Button E;
        private Button D;
        private Button C;
        private Button B;
        private Button A;
        private Label ErrorMessage;
        private Label label1;
        private Label label2;
    }
}

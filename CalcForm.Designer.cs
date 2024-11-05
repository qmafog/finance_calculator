namespace Big_calculator
{
    partial class CalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inputNumber1 = new System.Windows.Forms.TextBox();
            this.inputNumber2 = new System.Windows.Forms.TextBox();
            this.equalsButton = new System.Windows.Forms.Button();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.wrongFormatLabel1 = new System.Windows.Forms.Label();
            this.wrongFormatLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outOfRangeLabel1 = new System.Windows.Forms.Label();
            this.outOfRangeLabel2 = new System.Windows.Forms.Label();
            this.inputNumber3 = new System.Windows.Forms.TextBox();
            this.operationBox2 = new System.Windows.Forms.ComboBox();
            this.inputNumber4 = new System.Windows.Forms.TextBox();
            this.operationBox3 = new System.Windows.Forms.ComboBox();
            this.outOfRangeLabel4 = new System.Windows.Forms.Label();
            this.outOfRangeLabel3 = new System.Windows.Forms.Label();
            this.wrongFormatLabel3 = new System.Windows.Forms.Label();
            this.wrongFormatLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to calculator!";
            // 
            // inputNumber1
            // 
            this.inputNumber1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputNumber1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumber1.Location = new System.Drawing.Point(12, 37);
            this.inputNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(298, 19);
            this.inputNumber1.TabIndex = 1;
            this.inputNumber1.Enter += new System.EventHandler(this.inputNumber1_Enter);
            this.inputNumber1.Leave += new System.EventHandler(this.inputNumber1_Leave);
            // 
            // inputNumber2
            // 
            this.inputNumber2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputNumber2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumber2.Location = new System.Drawing.Point(12, 97);
            this.inputNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(298, 19);
            this.inputNumber2.TabIndex = 3;
            this.inputNumber2.Enter += new System.EventHandler(this.inputNumber2_Enter);
            this.inputNumber2.Leave += new System.EventHandler(this.inputNumber2_Leave);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(138, 251);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(2);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(56, 34);
            this.equalsButton.TabIndex = 4;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // operationBox
            // 
            this.operationBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationBox.Location = new System.Drawing.Point(138, 62);
            this.operationBox.Margin = new System.Windows.Forms.Padding(2);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(57, 28);
            this.operationBox.TabIndex = 2;
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.operationBox_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(12, 299);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(299, 26);
            this.resultBox.TabIndex = 5;
            // 
            // wrongFormatLabel1
            // 
            this.wrongFormatLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongFormatLabel1.ForeColor = System.Drawing.Color.Red;
            this.wrongFormatLabel1.Location = new System.Drawing.Point(314, 11);
            this.wrongFormatLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongFormatLabel1.Name = "wrongFormatLabel1";
            this.wrongFormatLabel1.Size = new System.Drawing.Size(134, 81);
            this.wrongFormatLabel1.TabIndex = 8;
            this.wrongFormatLabel1.Text = "Wrong number format!\r\nEnter float number.\r\n";
            this.wrongFormatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongFormatLabel1.Visible = false;
            // 
            // wrongFormatLabel2
            // 
            this.wrongFormatLabel2.AutoSize = true;
            this.wrongFormatLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongFormatLabel2.ForeColor = System.Drawing.Color.Red;
            this.wrongFormatLabel2.Location = new System.Drawing.Point(314, 93);
            this.wrongFormatLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongFormatLabel2.Name = "wrongFormatLabel2";
            this.wrongFormatLabel2.Size = new System.Drawing.Size(132, 26);
            this.wrongFormatLabel2.TabIndex = 9;
            this.wrongFormatLabel2.Text = "Wrong number format!\r\nEnter float number.";
            this.wrongFormatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongFormatLabel2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Король Иван Александрович, 3 курс, 11 группа, 2024";
            // 
            // outOfRangeLabel1
            // 
            this.outOfRangeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outOfRangeLabel1.ForeColor = System.Drawing.Color.Red;
            this.outOfRangeLabel1.Location = new System.Drawing.Point(314, 11);
            this.outOfRangeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outOfRangeLabel1.Name = "outOfRangeLabel1";
            this.outOfRangeLabel1.Size = new System.Drawing.Size(134, 81);
            this.outOfRangeLabel1.TabIndex = 11;
            this.outOfRangeLabel1.Text = "Wrong number format!\r\nOut of range.\r\n";
            this.outOfRangeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outOfRangeLabel1.Visible = false;
            // 
            // outOfRangeLabel2
            // 
            this.outOfRangeLabel2.AutoSize = true;
            this.outOfRangeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outOfRangeLabel2.ForeColor = System.Drawing.Color.Red;
            this.outOfRangeLabel2.Location = new System.Drawing.Point(314, 92);
            this.outOfRangeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outOfRangeLabel2.Name = "outOfRangeLabel2";
            this.outOfRangeLabel2.Size = new System.Drawing.Size(132, 26);
            this.outOfRangeLabel2.TabIndex = 12;
            this.outOfRangeLabel2.Text = "Wrong number format!\r\nOut of range.";
            this.outOfRangeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outOfRangeLabel2.Visible = false;
            // 
            // inputNumber3
            // 
            this.inputNumber3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputNumber3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumber3.Location = new System.Drawing.Point(12, 159);
            this.inputNumber3.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber3.Name = "inputNumber3";
            this.inputNumber3.Size = new System.Drawing.Size(298, 19);
            this.inputNumber3.TabIndex = 14;
            this.inputNumber3.Enter += new System.EventHandler(this.inputNumber3_Enter);
            this.inputNumber3.Leave += new System.EventHandler(this.inputNumber3_Leave);
            // 
            // operationBox2
            // 
            this.operationBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operationBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operationBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBox2.FormattingEnabled = true;
            this.operationBox2.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationBox2.Location = new System.Drawing.Point(138, 124);
            this.operationBox2.Margin = new System.Windows.Forms.Padding(2);
            this.operationBox2.Name = "operationBox2";
            this.operationBox2.Size = new System.Drawing.Size(57, 28);
            this.operationBox2.TabIndex = 13;
            this.operationBox2.SelectedIndexChanged += new System.EventHandler(this.operationBox2_SelectedIndexChanged);
            // 
            // inputNumber4
            // 
            this.inputNumber4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputNumber4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumber4.Location = new System.Drawing.Point(12, 219);
            this.inputNumber4.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber4.Name = "inputNumber4";
            this.inputNumber4.Size = new System.Drawing.Size(298, 19);
            this.inputNumber4.TabIndex = 16;
            this.inputNumber4.Enter += new System.EventHandler(this.inputNumber4_Enter);
            this.inputNumber4.Leave += new System.EventHandler(this.inputNumber4_Leave);
            // 
            // operationBox3
            // 
            this.operationBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operationBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operationBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationBox3.FormattingEnabled = true;
            this.operationBox3.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationBox3.Location = new System.Drawing.Point(138, 184);
            this.operationBox3.Margin = new System.Windows.Forms.Padding(2);
            this.operationBox3.Name = "operationBox3";
            this.operationBox3.Size = new System.Drawing.Size(57, 28);
            this.operationBox3.TabIndex = 15;
            this.operationBox3.SelectedIndexChanged += new System.EventHandler(this.operationBox3_SelectedIndexChanged);
            // 
            // outOfRangeLabel4
            // 
            this.outOfRangeLabel4.AutoSize = true;
            this.outOfRangeLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outOfRangeLabel4.ForeColor = System.Drawing.Color.Red;
            this.outOfRangeLabel4.Location = new System.Drawing.Point(314, 212);
            this.outOfRangeLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outOfRangeLabel4.Name = "outOfRangeLabel4";
            this.outOfRangeLabel4.Size = new System.Drawing.Size(132, 26);
            this.outOfRangeLabel4.TabIndex = 17;
            this.outOfRangeLabel4.Text = "Wrong number format!\r\nOut of range.";
            this.outOfRangeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outOfRangeLabel4.Visible = false;
            // 
            // outOfRangeLabel3
            // 
            this.outOfRangeLabel3.AutoSize = true;
            this.outOfRangeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outOfRangeLabel3.ForeColor = System.Drawing.Color.Red;
            this.outOfRangeLabel3.Location = new System.Drawing.Point(314, 152);
            this.outOfRangeLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outOfRangeLabel3.Name = "outOfRangeLabel3";
            this.outOfRangeLabel3.Size = new System.Drawing.Size(132, 26);
            this.outOfRangeLabel3.TabIndex = 18;
            this.outOfRangeLabel3.Text = "Wrong number format!\r\nOut of range.";
            this.outOfRangeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outOfRangeLabel3.Visible = false;
            // 
            // wrongFormatLabel3
            // 
            this.wrongFormatLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongFormatLabel3.ForeColor = System.Drawing.Color.Red;
            this.wrongFormatLabel3.Location = new System.Drawing.Point(314, 131);
            this.wrongFormatLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongFormatLabel3.Name = "wrongFormatLabel3";
            this.wrongFormatLabel3.Size = new System.Drawing.Size(134, 81);
            this.wrongFormatLabel3.TabIndex = 19;
            this.wrongFormatLabel3.Text = "Wrong number format!\r\nEnter float number.\r\n";
            this.wrongFormatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongFormatLabel3.Visible = false;
            // 
            // wrongFormatLabel4
            // 
            this.wrongFormatLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongFormatLabel4.ForeColor = System.Drawing.Color.Red;
            this.wrongFormatLabel4.Location = new System.Drawing.Point(314, 190);
            this.wrongFormatLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongFormatLabel4.Name = "wrongFormatLabel4";
            this.wrongFormatLabel4.Size = new System.Drawing.Size(134, 81);
            this.wrongFormatLabel4.TabIndex = 20;
            this.wrongFormatLabel4.Text = "Wrong number format!\r\nEnter float number.\r\n";
            this.wrongFormatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongFormatLabel4.Visible = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(449, 374);
            this.Controls.Add(this.wrongFormatLabel4);
            this.Controls.Add(this.wrongFormatLabel3);
            this.Controls.Add(this.outOfRangeLabel3);
            this.Controls.Add(this.outOfRangeLabel4);
            this.Controls.Add(this.inputNumber4);
            this.Controls.Add(this.operationBox3);
            this.Controls.Add(this.inputNumber3);
            this.Controls.Add(this.operationBox2);
            this.Controls.Add(this.outOfRangeLabel2);
            this.Controls.Add(this.outOfRangeLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wrongFormatLabel2);
            this.Controls.Add(this.wrongFormatLabel1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.inputNumber2);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.Text = "Financial calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNumber1;
        private System.Windows.Forms.TextBox inputNumber2;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label wrongFormatLabel1;
        private System.Windows.Forms.Label wrongFormatLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outOfRangeLabel1;
        private System.Windows.Forms.Label outOfRangeLabel2;
        private System.Windows.Forms.TextBox inputNumber3;
        private System.Windows.Forms.ComboBox operationBox2;
        private System.Windows.Forms.TextBox inputNumber4;
        private System.Windows.Forms.ComboBox operationBox3;
        private System.Windows.Forms.Label outOfRangeLabel4;
        private System.Windows.Forms.Label outOfRangeLabel3;
        private System.Windows.Forms.Label wrongFormatLabel3;
        private System.Windows.Forms.Label wrongFormatLabel4;
    }
}


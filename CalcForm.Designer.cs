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
            this.inputNumber1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.inputNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(298, 19);
            this.inputNumber2.TabIndex = 3;
            this.inputNumber2.Enter += new System.EventHandler(this.inputNumber2_Enter);
            this.inputNumber2.Leave += new System.EventHandler(this.inputNumber2_Leave);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(138, 122);
            this.equalsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            "-"});
            this.operationBox.Location = new System.Drawing.Point(138, 62);
            this.operationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(57, 28);
            this.operationBox.TabIndex = 2;
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.operationBox_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(12, 161);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label4.Location = new System.Drawing.Point(10, 226);
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
            this.outOfRangeLabel2.Location = new System.Drawing.Point(314, 93);
            this.outOfRangeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outOfRangeLabel2.Name = "outOfRangeLabel2";
            this.outOfRangeLabel2.Size = new System.Drawing.Size(132, 26);
            this.outOfRangeLabel2.TabIndex = 12;
            this.outOfRangeLabel2.Text = "Wrong number format!\r\nOut of range.";
            this.outOfRangeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outOfRangeLabel2.Visible = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(449, 246);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}


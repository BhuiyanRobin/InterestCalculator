namespace InterestCalculator
{
    partial class InterestCalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.principalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timePeriodTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // principalAmountTextBox
            // 
            this.principalAmountTextBox.Location = new System.Drawing.Point(163, 23);
            this.principalAmountTextBox.Name = "principalAmountTextBox";
            this.principalAmountTextBox.Size = new System.Drawing.Size(188, 20);
            this.principalAmountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Annula Interest Rate(%)";
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(163, 65);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(188, 20);
            this.interestTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Period( in year)";
            // 
            // timePeriodTextBox
            // 
            this.timePeriodTextBox.Location = new System.Drawing.Point(163, 108);
            this.timePeriodTextBox.Name = "timePeriodTextBox";
            this.timePeriodTextBox.Size = new System.Drawing.Size(188, 20);
            this.timePeriodTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Amount (Result)";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(165, 211);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(186, 20);
            this.totalAmountTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(171, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 53);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Noted that Interest Calculation Interval : Yearly";
            // 
            // InterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timePeriodTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principalAmountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculatorUI";
            this.Text = "InterestCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principalAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timePeriodTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
    }
}


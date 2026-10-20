namespace CalculatorApplication
{
    partial class FrmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNumberLbl = new Label();
            secondNumberLbl = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            label1 = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // firstNumberLbl
            // 
            firstNumberLbl.AutoSize = true;
            firstNumberLbl.Font = new Font("Segoe UI", 11F);
            firstNumberLbl.Location = new Point(68, 67);
            firstNumberLbl.Name = "firstNumberLbl";
            firstNumberLbl.Size = new Size(139, 20);
            firstNumberLbl.TabIndex = 0;
            firstNumberLbl.Text = "Enter First Number: ";
            // 
            // secondNumberLbl
            // 
            secondNumberLbl.AutoSize = true;
            secondNumberLbl.Font = new Font("Segoe UI", 11F);
            secondNumberLbl.Location = new Point(46, 166);
            secondNumberLbl.Name = "secondNumberLbl";
            secondNumberLbl.Size = new Size(161, 20);
            secondNumberLbl.TabIndex = 1;
            secondNumberLbl.Text = "Enter Second Number: ";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(228, 64);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(137, 29);
            txtBoxInput1.TabIndex = 2;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(228, 159);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(137, 29);
            txtBoxInput2.TabIndex = 3;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(263, 113);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(68, 27);
            cbOperator.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(143, 215);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Answer: ";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(230, 215);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(136, 21);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "__________________";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.Location = new Point(244, 268);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(111, 32);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 387);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(secondNumberLbl);
            Controls.Add(firstNumberLbl);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNumberLbl;
        private Label secondNumberLbl;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label label1;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}

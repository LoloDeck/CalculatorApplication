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
            lblAnswer = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // firstNumberLbl
            // 
            firstNumberLbl.AutoSize = true;
            firstNumberLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            firstNumberLbl.Location = new Point(41, 48);
            firstNumberLbl.Name = "firstNumberLbl";
            firstNumberLbl.Size = new Size(181, 25);
            firstNumberLbl.TabIndex = 0;
            firstNumberLbl.Text = "Enter First Number: ";
            // 
            // secondNumberLbl
            // 
            secondNumberLbl.AutoSize = true;
            secondNumberLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            secondNumberLbl.Location = new Point(14, 166);
            secondNumberLbl.Name = "secondNumberLbl";
            secondNumberLbl.Size = new Size(203, 25);
            secondNumberLbl.TabIndex = 1;
            secondNumberLbl.Text = "Enter Second Number: ";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(238, 39);
            txtBoxInput1.Margin = new Padding(3, 4, 3, 4);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(156, 34);
            txtBoxInput1.TabIndex = 2;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(238, 160);
            txtBoxInput2.Margin = new Padding(3, 4, 3, 4);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(156, 34);
            txtBoxInput2.TabIndex = 3;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(274, 103);
            cbOperator.Margin = new Padding(3, 4, 3, 4);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(77, 31);
            cbOperator.TabIndex = 4;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(137, 236);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(84, 25);
            lblAnswer.TabIndex = 5;
            lblAnswer.Text = "Answer: ";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(238, 233);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(156, 28);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "__________________";
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Crimson;
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.Location = new Point(246, 300);
            btnEqual.Margin = new Padding(3, 4, 3, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(137, 43);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(424, 385);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblAnswer);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(secondNumberLbl);
            Controls.Add(firstNumberLbl);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblAnswer;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}

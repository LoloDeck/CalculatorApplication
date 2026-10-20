using System.Drawing.Text;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();

            char[] Operators = new char[] { '+', '-', '*', '/' };

            for (int i = 0; i < Operators.Length; i++)
            {
                char op = Operators[i];
                cbOperator.Items.Add(op);
            }
        }

           private void btnEqual_Click(object sender, EventArgs e)
            {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            char op = Convert.ToChar(cbOperator.SelectedItem);
            
            lblDisplayTotal.Text = "" + result.ToString();
            }
            private double Calculate(double num1, double num2, char op)
            {
                switch (op)
                {
                case '+':
                    Formula
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                default:
                    throw new InvalidOperationException("Invalid operator.");
                }
            }

    }
}

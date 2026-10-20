using System.Drawing.Text;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();

            char[] Operators = new char[] { '+', '-', '*', '/' };

            for (int i = 0; i < Operators.Length; i++)
            {
                char op = Operators[i];
                cbOperator.Items.Add(op);
            }
        }

           private void btnEqual_Click(object sender, EventArgs e)
            {
            if (cbOperator.SelectedItem == null)
            {
                MessageBox.Show("Please select an operator.");
                return;
            }

            try
            {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            char op = Convert.ToChar(cbOperator.SelectedItem);
            
                Formula<double> formula;
                switch (op)
                {
                case '+':
                        formula = new Formula<double>(cal.getSum);
                        break;
                case '-':
                        formula = new Formula<double>(cal.getSub);
                        break;
                case '*':
                        formula = new Formula<double>(cal.getMul);
                        break;
                case '/':
                        formula = new Formula<double>(cal.getDivide);
                        break;
                default:
                    throw new InvalidOperationException("Invalid operator.");

                }
                cal.CalculateEvent += formula;
                try
                {
                    lblDisplayTotal.Text = cal.info(num1, num2).ToString();
                }
                finally
                {
                    cal.CalculateEvent -= formula;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                }
            }

    }
}

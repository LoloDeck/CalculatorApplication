using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T formula<T,R>(T num1, T num2, R op);
    class CalculatorClass
    {
        
        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double getSub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double getMul(double num1, double num2)
        {
            return num1 * num2;
        }
        public double divide(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

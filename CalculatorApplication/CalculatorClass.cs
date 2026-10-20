using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T num1, T num2);
    class CalculatorClass
    {
        public Formula<double> info;
        
        public event Formula<double> CalculateEvent
        {
            add 
            { 
                Console.WriteLine("Adding the Delegate");
                info += value; 
            }
            remove 
            { 
                Console.WriteLine("Removing the Delegate");
                info -= value;
            }
        }
        
        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public double getQuotient(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

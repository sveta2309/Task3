using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Calc
    {
        public double Calculation(string s)
        {
            List<string> numbers = new List<string>();
            numbers.AddRange(s.Split(' '));
            double firstNumber = Convert.ToDouble(numbers[0]);
            double secondNumber = Convert.ToDouble(numbers[1]);
            double thirdNumber = Convert.ToDouble(numbers[2]);
            double forthNumber = Convert.ToDouble(numbers[3]);
            double fifthNumber = Convert.ToDouble(numbers[4]);

            double a = FirstAction(forthNumber, fifthNumber);
            double b = SecondAction(a);
            double c = ThirdAction(thirdNumber, b);
            double d = ForthAction(secondNumber, c);
            return FifthAction(firstNumber, d);
      
        }
        public double FirstAction(double a, double b)
        {
            return a - b;
        }
        public double SecondAction(double a)
        {
            return a * a;
        }
        public double ThirdAction(double a, double b)
        {
            return a / b;
        }
        public double ForthAction(double a, double b)
        {
            return a *b;
        }
        public double FifthAction(double a, double b)
        {
            return a +b;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Calc calc = new Calc();
            menu.AskNumbers();
            string s = menu.ReadNumbers();
            Console.WriteLine ("The answer is " + calc.Calculation(s));
            Console.ReadLine();
        }
    }
}

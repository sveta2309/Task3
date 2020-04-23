using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Menu
    {
        public void AskNumbers()
        {
            Console.WriteLine("Enter numbers via space");
        }
        public string ReadNumbers()
        {
            string s = Console.ReadLine();
            return s;
        }

    }
}

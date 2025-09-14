using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Variables
    {
        public static void ShowVariables()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {a + b}");

            int num = int.Parse(Console.ReadLine());

            if (num > 20)
            {
                Console.WriteLine("buy a book");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIPA
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Show");
        }
    }

     class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("Child Show");
        }
    }

    internal class Polymorphism
    {   
        static int Sum(int a, int b)
        {
            return a + b;
        }
       static double Sum( double a, double b)
        {
            return a + b;
        }
        public static void Run()
        {
            // function overLoading
            int  result = Sum(10, 20);
            double result2= Sum(10.5, 20.5);
            Console.WriteLine(result);
            Console.WriteLine(result2);


            Parent p1 = new Parent();
            p1.Show();   // Output: Parent Show

            Child c1 = new Child();
            c1.Show();   // Output: Child Show
        }
    }
}

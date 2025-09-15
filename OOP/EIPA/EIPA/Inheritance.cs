using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIPA
{    class A
    {
        int age;
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    class B:A
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Inheritance
    {
        public static void Run2()
        {
            B user = new B();
            user.Age = 5;
            user.Name = "abir";

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Age);
        }
    }
}

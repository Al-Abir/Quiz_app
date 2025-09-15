using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIPA
{  // Blueprint
    abstract class Car
    {
        // আমি জানাচ্ছি start করতে পারবে
        public abstract void StartEngine(); // এখানে শুধু কাজের নাম

        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    // Real implementation hidden
    class BMW : Car
    {
        public override void StartEngine()
        {
            
            // এই ভিতরের কোড driver বা caller কখনো দেখবে না
            Console.WriteLine("Fuel injected");
            Console.WriteLine("Spark plug fired");
            Console.WriteLine("Engine running");
        }
    }

   
    internal class Abstractions
    {
       public static void Run3()
        {
            Car myCar = new BMW(); // driver শুধু Car হিসেবে জানে
            myCar.StartEngine();   // driver শুধু call করতে পারে
            myCar.Drive();         // normal method
        }
    }
}

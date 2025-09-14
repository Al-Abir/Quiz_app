using System;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static int total = 0;
        public static void Main()
        {
            int[] arr = { 1, 3, 3, 4, 5 };

            // সাধারণ foreach loop
            foreach (int i in arr)
            {
                total += arr[i];
            }

            Console.WriteLine("For loop output:"+ total);

            // Parallel.For loop
            Parallel.For(0, arr.Length, i =>
            {
                total += arr[i];
            });

            Console.WriteLine("Parallel.For loop output:" + total);
        }
    }
}

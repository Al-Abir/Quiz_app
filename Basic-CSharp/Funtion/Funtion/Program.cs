using System;

class Program
{   
     void printNumber(params int[] numbers)  
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
    static void Greet(string name = "Guest")
    {
        Console.WriteLine($"Hello {name}");
    }
    public static void Main()
    {
        var p = new Program();

        p.printNumber(1, 2, 3, 4, 5);
        Greet();
        Greet("Rohim");
    }
}

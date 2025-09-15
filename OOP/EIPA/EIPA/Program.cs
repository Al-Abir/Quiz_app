using System;

class Stack_heap
{
    private int age;

    // property
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class Program
{
    static void func1()
    {
        // heap memory (object create with new)
        Stack_heap stack = new Stack_heap();
        stack.Age = 10;
        Console.WriteLine(stack.Age);
    }

    public static void Main()
    {
        // memory access (func1)
        func1();

        // heap memory (another object)
        Stack_heap hp = new Stack_heap();
        hp.Age = 20;
        Console.WriteLine(hp.Age);
        //// call Polymorphism example
        EIPA.Polymorphism.Run();

        //call inheritance
        EIPA.Inheritance.Run2();

        // call Abstration
        EIPA.Abstractions.Run3();
    }
}

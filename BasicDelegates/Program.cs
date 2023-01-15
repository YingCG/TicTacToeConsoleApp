using System;

namespace BasicDelegates
{
    // declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as static class functions
        public string addTwoThenMultiply(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Delegates work");

            MyDelegate result = addTwo;
            Console.WriteLine("Addiing two is: " + result(10,20));
            result = multiplyTwo;
            Console.WriteLine("Multiply two is: " + result(10, 20));

            MyClass mc = new MyClass();
            result = mc.addTwoThenMultiply;
            Console.WriteLine("The number is " + result(10, 20));
            Console.ReadLine();
        }

        // insert delegates here
        static string addTwo(int a, int b)
        {
            return (a + b).ToString();
        }

        static string multiplyTwo(int a, int b)
        {
            return (a * b).ToString();
        }
    }
}

using System;

namespace Anonymous_delegates
{
    public delegate int MyDelegate(int arg1, int arg2);
    public delegate void TheDelegate(int arg1, int arg2);
    //public delegate void SeconeDelegate(int arg1, ref int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Anonymous_delegates");

            //MyDelegate result = delegate (int arg1, int arg2)
            //{
            //    return (arg1 + arg2);
            //};
            //Console.WriteLine("Add two equal " + result(10, 20).ToString());

            Console.WriteLine("Composable_delegates");
            TheDelegate f1 = func1;
            TheDelegate f2 = func2;
            TheDelegate f1f2 = f1 + f2;
            Console.WriteLine("calling the first delegate");
            f1(10, 20);
            Console.WriteLine("calling the second delegate");
            f2(10, 20);
            Console.WriteLine("calling the chained delegate");
            f1f2(10, 20);

            Console.WriteLine("\ncalling the unchained delegates");
            f1f2 -= f1;
            f1f2(20, 20);
            Console.ReadLine();

          static void func1(int a, int b)
        {
            string result = (a + b).ToString();
            Console.WriteLine("Add two is " + result);
        }

        static void func2(int a, int b)
        {
            string result = (a * b).ToString();
            Console.WriteLine("Add two is " + result);
        }
        }
    }
}

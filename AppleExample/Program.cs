using System;

namespace AppleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Console.WriteLine(apple.AmountLeft);
            Console.WriteLine(apple.Organic);

            Apple apple1 = new Apple(50, true);
            Console.WriteLine(apple1.AmountLeft);
            Console.WriteLine(apple1.Organic);
        }
    }
}

using System;
using System.Collections.Concurrent;

namespace basics
{
    public class continueToCSharp
    {
        enum Operations
        {
            SUM,
            SUBTRACTION,
            MULTIPLICATION,
            DIVISION
        }
        public static void Main(string[] args)
        {
            /*
            if_else();
            switch_case();
            loops();
            */

        }

        private static void loops()
        {
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine("{0,-3} {1,3}", num, num * 5);
                num++;
            }
            int i = 0;
            do
            {
                Console.Write("{0,5}", i++);
            }
            while (i < 5);

            for (int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0},{1,-5}", k + 1, j + 1);
                }
                Console.WriteLine();
            }
        }

        private static void switch_case()
        {
            Console.WriteLine("Enter 2 numbers;");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Operations operation = (Operations)(new Random().Next(0, 3));
            switch (operation)
            {
                case Operations.SUM:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case Operations.SUBTRACTION:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case Operations.MULTIPLICATION:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case Operations.DIVISION:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    break;
            }
        }

        private static void if_else()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine($"{num} is an even number!");
            }
            else
                Console.WriteLine($"{num} is an odd number!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace basics
{
    public class Metods
    {
        public static void Main(string[] args)
        {
            welcomeMessage();
            var result = addingNums(1, 15.98, 14.9, 156);
            Console.WriteLine(result);
            result = addingNums(-59.789654, 15679, -9998.12);
            Console.WriteLine("{0,5:0.##}", result);

            account(.15);
            account(15, "abc");

            int a = 10; int b = 20;
            Console.WriteLine("{0},{1}", a, b);
            change_number(ref a, ref b);
            Console.WriteLine("{0},{1}", a, b);
            Lambda_Usage();

        }

        private static void Lambda_Usage()
        {
            List<String> city1 = new List<String>
            {
                "Ankara","Istanbul","Adana","Antalya"
            };
            var city2 = city1;
            //Lambda usage
            city1.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            city2.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();

            /*de to referance when we add(remove) new city to a list it is automaticly added(removed) other list too*/
            city1.Add("Bolu");
            city1.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            city2.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();

            city2.Remove("Adana");
            city1.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            city2.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void change_number(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        /// <summary>
        /// we can give detail information about metods in here
        /// </summary>
        /// <param name="money"></param>
        public static void account(double money)
        {
            Console.WriteLine($"Welcome customer you have {money}");
        }
        public static void account(double money,String name)
        {
            Console.WriteLine($"Welcome {name} you have {money}");
        }

        public static double addingNums(params double[] numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }
        public static void welcomeMessage()
        {
            Console.WriteLine("Welcome to our metod!");
        }
    }
}

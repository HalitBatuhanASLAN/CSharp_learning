using System;
using System.Collections.Concurrent;

namespace basics
{
    public class Program
    {
        /*public static void Main(string[] args)
        {
            basicMetod();
            escapeSeq();
            varUsage();
            stringMetods();

        }*/

        private static void stringMetods()
        {
            string str = "Welcome to learning c# program!";
            Console.WriteLine(str);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Trim());/*deletes spaces at the beginning and end*/
            Console.WriteLine(str.TrimEnd());
        }

        private static void varUsage()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input);
            string str_input = Console.ReadLine();
            Console.WriteLine(str_input);
            /*we can write var instead of consolekeyInfo*/
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(key.Key);
            Console.WriteLine(key.KeyChar);
        }

        private static void escapeSeq()
        {
            string escapeSequencyFirst = "First \\ way of using \\ in a string";
            string escapeSequencySecond = @"Second \ way of using \ in a string";
            Console.WriteLine(escapeSequencyFirst);
            Console.WriteLine(escapeSequencySecond);
        }

        private static void basicMetod()
        {
            int num = 15;
            double pi = 3.14;
            char character = 'a';

            Console.WriteLine(num);
            Console.WriteLine(pi);
            Console.WriteLine(character);
        }
    }
}
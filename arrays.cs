using System;
using System.Collections;
using System.Collections.Concurrent;

namespace basics
{
    public class arrays
    {
        public static void Main(string[] args)
        {
            /*
            array();
            mutiple_array();
            array_list();
            */
        }

        private static void array_list()
        {
            var items = new ArrayList();
            items.Add(15);
            items.Add("HBA");
            items.Add("Welcome to c# learning repo!");

            int[] nums = new int[3] { 1, 2, 3 };
            items.AddRange(nums);
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            items.Remove("HBA");
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            items.RemoveAt(2);
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            items.RemoveRange(1, 2);/*start from first index delete 2 elements*/
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
        }

        private static void mutiple_array()
        {
            double[,] multipleArray = new double[,]
                        {
                {1,2,3},
                {4,5,6},
                {7,8,9},
                {10,11,12},
                        };
            for (int i = 0; i < multipleArray.GetLength(0); i++)
            {
                for (int j = 0; j < multipleArray.GetLength(1); j++)
                {
                    if (i == j)
                        multipleArray[i, j] = 0;
                    Console.Write($"{multipleArray[i, j],3}");
                }
                Console.WriteLine();
            }
        }

        private static void array()
        {
            Console.WriteLine("Enter how many numbers will you want : ");
            int size_of_array = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size_of_array];
            Random num = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = num.Next(1, 10);
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item,5} {item * item,5}");
            }
        }
    }
}

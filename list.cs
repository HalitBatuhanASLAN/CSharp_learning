using System;
using System.Collections.Generic;

namespace basics
{
    class Lists
    {
        /*public static void Main(string[] args)
        {
            List_metod();
        }*/

        private static void List_metod()
        {
            List<int> num_list = new List<int>();
            num_list.Add(1);
            num_list.Add(10);
            int new_number = 15;
            num_list.Add(new_number);
            int[] arr = new int[] { 1, 2, 3, };
            num_list.AddRange(arr);
            num_list.Insert(0, new_number);
            num_list.InsertRange(1, new int[] { 9, 8, 7 });
            foreach (int i in num_list)
            {
                Console.Write($"{i,-5}");
            }
            num_list.RemoveAt(5);/*deletes number at index of 5*/
            num_list.RemoveAt(num_list.IndexOf(8));/*deletes 8*/
            Console.WriteLine();
            foreach (int i in num_list)
            {
                Console.Write($"{i,-5}");
            }
        }
    }
}

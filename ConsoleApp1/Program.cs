using System;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1 
            //int size = int.Parse(Console.ReadLine());

            //string[] name = new string[size];
            //int[] age = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"your age is {i + 1}");
            //    age[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"your name is {i + 1}");
            //    name[i] = Console.ReadLine();

            //}
            #endregion


            Console.WriteLine("Enter the array");
            string input = Console.ReadLine();

            var arr = input.Split(",");

            int s = arr.Length;

            int[] num_arr = new int[s];

            for (int i = 0; i < s; i++)
            {
                num_arr[i] = int.Parse(arr[i]);
            }
            int[] res = new int[s];

            for (int i = 0; i < s; i++)
            {
                int product = 1;
                num_arr[i] = int.Parse(arr[i]);

                for (int j = 0; j < s; j++)
                {
                    if (i != j)
                    {
                        product *= num_arr[j];
                    }
                }
                res[i] = product;
                Console.Write($"{res[i]}");
            }

        }
    }
}


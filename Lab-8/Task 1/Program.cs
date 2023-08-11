using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 56, 98, 43, -12, 24, 1, 7, 12, 341, 17, 32 };

            int middle = 0; 

            int array_count = array.Length; 
            int summary = 0; 
            for (int i = 0; i < array_count; i++)
            {
                summary += array[i];
            }
            middle = summary / array_count; 
            Console.WriteLine("Среднее арифметическое: {0}", middle);


            int min = int.MaxValue; 
            int max = int.MinValue; 
            for (int i = 0; i < array_count; i++)
            {
                int val = array[i];
                if (val < min)
                {
                    min = val;
                }
                if (val > max)
                {
                    max = val;
                }
            }

            Console.WriteLine("Минимальное значение: {0}\nМаксимальное значение: {1}", min, max);
            Console.ReadLine();
        }
    }
}
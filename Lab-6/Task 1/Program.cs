using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i=0;i<width;i++)
                {
                  Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

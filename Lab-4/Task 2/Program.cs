using System;

namespace Task_2
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                double firstValue, secondValue;
                string action;
                Console.WriteLine("введите число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("введите число 2");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("выберите операцию: '+' '-' '*' '/' ");
                action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Ошибка");
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }

                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.ReadLine();
            }
    }
}

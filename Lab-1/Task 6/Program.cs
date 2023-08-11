using System;

namespace Task_6
{
    class Converter
    {
        static void Main(string[] args)
        {
            
            double UahToUsd= 0.035;
            double UahToEur=0.030;
            double UahToRub = 2.76;
            double UAH;
            Console.WriteLine("Введите сумму в UAH");
            UAH = double.Parse(Console.ReadLine());
            Console.WriteLine( UAH + " в USD " + UAH*UahToUsd);
            Console.WriteLine( UAH + " в EUR " + UAH*UahToEur);
            Console.WriteLine( UAH + " в RUB " + UAH*UahToRub);
        }
    }
}

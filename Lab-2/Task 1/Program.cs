using System;

namespace Lab_1
{

    class Program
    {
        delegate int Operation(int firstValue, int secondValue,int thirdValue);
        static void Main(string[] args)
        {
            Operation operation = delegate (int firstValue, int secondValue, int thirdValue)
            { 
                return (firstValue + secondValue +thirdValue)/3;
            };
            int d = operation(4, 5,6);
            Console.WriteLine(d);       // 9
            Console.Read();
        }
    }
}

using System;
namespace PrintAndDeliveredPrint
{
        internal class Printer
        {
            public virtual void Print(string value)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine(value);
            }

        }
        internal class PrinterBlue : Printer
        {
            public override void Print(string value)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(value);
            }
        }

        internal class PrinterRed : Printer
        {
            public new void Print(string value)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(value);
                Console.ReadKey();
            }
        
        }
       

        internal class Program
        {
            private static void Main(string[] args)
            {
                var arr = new Printer[3];
                arr[0] = new Printer();
                arr[1] = new PrinterBlue();
                arr[2] = new PrinterRed();

                foreach (Printer r in arr)
                {
                    r.Print("KNUTE");
                }

                ((PrinterRed)arr[2]).Print("KNUTE");
            }

        }
}
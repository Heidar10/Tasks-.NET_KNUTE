using System;

namespace Lab_3
{
    class Program
    {
        
            static void Too(int i)
            {
                Console.WriteLine(i) ;
                if (i == 3)
                    return;

                i++;
                Too(i);
            }
            static void Main(string[] args)
            {
                Too(0);
            }
           
        

    }
}

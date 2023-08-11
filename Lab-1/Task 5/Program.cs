using System;
using System.Collections.Generic;
using System.Xml;
namespace Task_5
{
    class User
    {
        static void Main()
        {
            string name;
            Console.WriteLine("What is your name and surname");
            name = Console.ReadLine();
            string years;
            Console.WriteLine("How old are you");
            years = Console.ReadLine();
            string date;
            Console.WriteLine("When you filled out the questionnaire");
            date = Console.ReadLine();
            Console.WriteLine("input login");
            string login = Console.ReadLine();
            Console.WriteLine("input password");
            string password = Console.ReadLine();

            var dict = new Dictionary <string, string>();
            dict.Add("Tiger", "56789");
            
            if (dict.ContainsKey(login))
                if (dict[login] == password)
                    Console.WriteLine("Hello " + name);
                else Console.WriteLine("wrong password");
            else Console.WriteLine("no such login");
            Console.ReadKey(true);

        }
    }
}

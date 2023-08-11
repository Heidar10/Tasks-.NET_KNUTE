using System;
using System.Collections.Generic;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Ukraine");
            countries.Add(3, "Turkey");
            countries.Add(2, "USA");
            countries.Add(4, "Germany");
            countries.Add(5, "Korea");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // получение элемента по ключу
            string country = countries[4];
            // изменение объекта
            countries[4] = "Spain";
            // удаление по ключу
            countries.Remove(2);
        }
    }
}

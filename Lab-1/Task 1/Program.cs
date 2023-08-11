using System;
using System.Xml;

namespace ЛБ_1
{
    //Task 1
    class Address
    {
        static void Main(string[] args)
        {
            string country;
            Console.WriteLine("В какой стране ты живешь: ");
            country=Console.ReadLine();
           

            string city;
            Console.WriteLine("В какой городе ты живешь: ");
            city = Console.ReadLine();

            string street;
            Console.WriteLine("На какой улице ты живешь: ");
            street = Console.ReadLine();

            string house;
            Console.WriteLine("В каком доме ты живешь: ");
            house = Console.ReadLine();
           
            string apartment;
            Console.WriteLine("В какой квартире ты живешь: ");
            apartment = Console.ReadLine();

            string index;
            Console.WriteLine("Почтовый индекс: ");
            index = Console.ReadLine();

            Console.WriteLine("страна: " + country);
            Console.WriteLine("город: " +city);
            Console.WriteLine("улица: " + street);
            Console.WriteLine("дом: " + house);
            Console.WriteLine("квартира: " + apartment);
            Console.WriteLine("Почтовый индекс: " + index);
            Console.ReadKey();

        }
    }
}

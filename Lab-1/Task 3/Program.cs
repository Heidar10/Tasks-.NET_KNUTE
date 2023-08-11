using System;
using System.Net;

namespace Task_3
{
    class Program
    {
        class Book
        {
            private string author;
            private string title;
            private string content ;
            
            public Book(string author, string title, string content)
            {
                Author = author;
                Title = title;
                Content = content;
             
            }
            
            public void Show()
            {
                Console.WriteLine("\n книга: {0}\n автор: {1}\n содержание {2}\n", author, title, content);
            }
            public string Author
            {
                get
                {
                    return author;
                }
                set
                {
                    author = value;
                }
            }
            public string Title
            {
                get
                {
                    return title;
                }
                set
                {
                    title = value;
                }
            }
            public string Content
            {
                get
                {
                    return content;
                }
                set
                {
                    content = value;
                }
            }
           
           
        }
        static void Main()
        {
            Book b1 = new Book("Костенко Л.В", "ТЕЛЕГРАМА-БЛИСКАВКА", "Вночі за вовчими ярами" +
                "зайці давали телеграми." +
                "І прочитала так сосна:" +
                "Чекайте квітами Весна");
           
            b1.Show();
            Book b2 = new Book("Костенко Л.В", "СОЛОВЕЙКО ЗАСТУДИВСЯ", "Дощик, дощик, ти вже злива! "+
                "Плаче груша, плаче слива." +
                "Ти періщить заходився,соловейко застудився." +
                "А тепер лежить під пледом," +
                "п'є гарячий чай із медом.");
            b2.Show();
           
            Console.ReadKey();
        }
    }

}              



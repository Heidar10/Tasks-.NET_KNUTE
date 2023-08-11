using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Shop
{
    class Store
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter textWritter = new XmlTextWriter("data.xml", Encoding.UTF8);
            List<Store> List = new List<Store>();
            int pos = -1;

            Console.WriteLine("Программа начала работу.");
            while (true)
            {

                Console.WriteLine("Для добавления данных введите 1");
                Console.WriteLine("Для вывода данных введите 2");
                Console.WriteLine("Для сохранения данных в файл введите 3");
                Console.WriteLine("Для выгрузки данных из файла введите 4");
                pos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (pos)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите названия продукта");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите цену");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите описания товара");
                            string decs = Console.ReadLine();
                            List.Add(new Store() { Name = name, Description = decs, Price = price });

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Имеющиеся товары в магазине");
                            foreach (var a in List)
                            {
                                Console.WriteLine("Название " + a.Name + " цена: " + a.Price);
                                Console.WriteLine("Описание: " + a.Description);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            textWritter.WriteStartDocument();
                            textWritter.WriteStartElement("Shop");
                            textWritter.WriteEndElement();
                            textWritter.Close();

                            XmlDocument doc = new XmlDocument();
                            doc.Load("data.xml");

                            foreach (var d in List)
                            {
                                XmlNode node = doc.CreateElement("Element");
                                doc.DocumentElement.AppendChild(node);
                                XmlAttribute attr = doc.CreateAttribute("name");
                                attr.Value = d.Name;
                                node.Attributes.Append(attr);

                                XmlAttribute attr1 = doc.CreateAttribute("price");
                                attr1.Value = d.Price.ToString();
                                node.Attributes.Append(attr1);

                                XmlAttribute attr2 = doc.CreateAttribute("description");
                                attr2.Value = d.Description;
                                node.Attributes.Append(attr2);
                            }

                            doc.Save("data.xml");
                            break;
                        }
                    case 4:
                        {
                            List.Clear();
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load("data.xml");
                            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                            {
                                Store str = new Store();
                                str.Name = node.Attributes.GetNamedItem("name").Value;
                                str.Description = node.Attributes.GetNamedItem("description").Value;
                                str.Price = Convert.ToInt32(node.Attributes.GetNamedItem("price").Value);
                                List.Add(str);
                            }
                            break;
                        }
                }
            }

        }
    }
}
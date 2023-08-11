using System;

namespace Task 
{
    abstract class AbstractHandler
    {
        private const string password = "111";
        

        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter password:");
            var license = Console.ReadLine();

            
            DocumentWorker worker;
            switch (license)
            {
                case password: worker = new ProDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }
                Console.WriteLine("Enter Command (open/edit/save/question): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }   
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
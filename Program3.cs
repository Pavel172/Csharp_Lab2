using System;



public class DocumentWorker 
{
    public virtual void OpenDocument() 
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument() 
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }
    public virtual void SaveDocument() 
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

public class ProDocumentWorker: DocumentWorker 
{
    public override void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            DocumentWorker doc = new DocumentWorker();
            Console.WriteLine("Введите ключ доступа pro и expert:");
            string key = Console.ReadLine();
            if(key == "") 
            {
                Console.WriteLine("Ключ не введён, вам предоставлена бесплатная версия");
            }
            if(key == "pro") 
            {
                Console.WriteLine("Ключ был введён, вам предоставлена pro версия");
                doc = new ProDocumentWorker();
            }
            if (key == "exp")
            {
                Console.WriteLine("Ключ был введён, вам предоставлена expert версия");
                doc = new ExpertDocumentWorker();
            }
        }
    }
}

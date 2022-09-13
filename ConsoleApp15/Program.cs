namespace ConsoleApp15;

class DocumentProgram
{
    public void OpenDocument() {
        Console.WriteLine("Document Opened");
    }

    public virtual void EditDocument() { 
        Console.WriteLine("Can Edit in Pro and Expert versions"); 
    }

    public virtual void SaveDocument() { 
        Console.WriteLine("Can Save in Pro and Expert versions");
    }


}

class ProDocumentProgram : DocumentProgram
{
    public void OpenDocument() { 
        Console.WriteLine("Document Opened"); 
    }

    public sealed override void EditDocument() { 
        Console.WriteLine("Can Edit in Pro and Expert versions"); 
    }

    public sealed override void SaveDocument() { 
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet"); 
    }
}

class ExpertDocument : ProDocumentProgram
{
    public void OpenDocument() { 
        Console.WriteLine("Document Opened"); 
    }

    public void EditDocument() { 
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }

    public void SaveDocument() {
        Console.WriteLine("Document Saved in pdf format"); 
    }

}

class Program
{
    static void Main()
    {


        byte select = 0;
        ConsoleKeyInfo keyInfo;
        ConsoleKeyInfo keyInfo2;
        bool start = true;
        while (true)
        {
            start = true;
            while (start)
            {
                if (select == 0)
                {
                    Console.WriteLine("\t\t\t<< Basic >>");
                    Console.WriteLine("\t\t\t   Pro");
                    Console.WriteLine("\t\t\t   Expert");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 1)
                {
                    Console.WriteLine("\t\t\t   Basic");
                    Console.WriteLine("\t\t\t<< Pro >>");
                    Console.WriteLine("\t\t\t   Expert");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 2)
                {
                    Console.WriteLine("\t\t\t   Basic ");
                    Console.WriteLine("\t\t\t   Pro");
                    Console.WriteLine("\t\t\t<< Expert >>");
                    Console.WriteLine("\t\t\t   Cixish");
        
                }
                else if (select == 3)
                {
                    Console.WriteLine("\t\t\t   Basic");
                    Console.WriteLine("\t\t\t   Pro");
                    Console.WriteLine("\t\t\t   Expert");
                    Console.WriteLine("\t\t\t<< Cixish >>");
                }
        
                keyInfo = Console.ReadKey();
                Console.Clear();
        
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (select != 0)
                            select--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (select + 1 < 5)
                            select++;
                        break;
                    case ConsoleKey.Enter:
                        start = false;
                        break;
                    default:
                        break;
                }
            }


            if (select == 0)
            {
                DocumentProgram basic = new DocumentProgram();
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
            }
            else if (select == 1)
            {
                DocumentProgram pro = new ProDocumentProgram();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if (select == 2)
            {
                DocumentProgram expert = new ExpertDocument();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }
            else if(select == 3)
            {
                break;
            }


            Console.WriteLine("\n\t\t\t  Cixmaq Ucun Tab Basin");
            Console.WriteLine("\t\t\t  Davam Etmek Ucun Enter Basin");
            keyInfo2 = Console.ReadKey();
            if (keyInfo2.Key is ConsoleKey.Enter)
            {
                Console.Clear();
            }
            else if (keyInfo2.Key is ConsoleKey.Tab)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }


        }
    }
}
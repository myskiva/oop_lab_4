using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Keys;
            Console.WriteLine("Enter the desired product version (free; pro; expert):");
            Keys = Console.ReadLine();

            switch (Keys)
            {
                case "free":
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("You have selected the free version");
                        DocumentWorker docworker = new DocumentWorker();
                        string Free;
                        Console.WriteLine("What do you want to do with the document? (open, edit, save)");
                        Free = Console.ReadLine();

                        switch (Free)
                        {
                            case "open":
                                {
                                    docworker.OpenDocument();
                                    try
                                    {
                                        StreamReader sr = new StreamReader("lab4_3.txt");
                                        string line;
                                        line = sr.ReadLine();
                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = sr.ReadLine();
                                            sr.Close();
                                            Console.ReadLine();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    break;
                                }
                            case "edit":
                                {
                                    docworker.EditDocument();
                                    break;
                                }
                            case "save":
                                {
                                    docworker.SaveDocument();
                                    break;
                                }
                            default:
                                Console.OutputEncoding = Encoding.UTF8;
                                Console.WriteLine("Sorry, this action is not available (:");
                                break;
                        }
                        break;
                    }

                case "pro":
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("You have selected the pro version");
                        ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                        string Pro;
                        Console.WriteLine("What do you want to do with the document? (open, edit, save)");
                        Pro = Console.ReadLine();

                        switch (Pro)
                        {
                            case "open":
                                {
                                    proDocumentWorker.OpenDocument();
                                    try
                                    {
                                        StreamReader sr = new StreamReader("lab4_3.txt");
                                        string line;
                                        line = sr.ReadLine();
                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = sr.ReadLine();
                                            sr.Close();
                                            Console.ReadLine();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    break;
                                }
                            case "edit":
                                {
                                    try
                                    {
                                        StreamWriter sw = new StreamWriter("lab4_3.txt");
                                        string edit_exp;
                                        edit_exp = Console.ReadLine();
                                        sw.WriteLine(edit_exp);
                                        sw.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    proDocumentWorker.EditDocument();
                                    break;
                                }
                            case "save":
                                {
                                    proDocumentWorker.SaveDocument();
                                    break;
                                }
                            default:
                                Console.OutputEncoding = Encoding.UTF8;
                                Console.WriteLine("Sorry, this action is not available (:");
                                break;
                        }
                        break;
                    }

                case "expert":
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("You have selected the expert version");
                        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                        string Exp;
                        Console.WriteLine("What do you want to do with the document? (open, edit, save)");
                        Exp = Console.ReadLine();

                        switch (Exp)
                        {
                            case "open":
                                {
                                    expertDocumentWorker.OpenDocument();
                                    try
                                    {
                                        StreamReader sr = new StreamReader("lab4_3.txt");
                                        string line;
                                        line = sr.ReadLine();
                                        while (line != null)
                                        {
                                            Console.WriteLine(line);
                                            line = sr.ReadLine();
                                            sr.Close();
                                            Console.ReadLine();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    break;
                                }
                            case "edit":
                                {
                                    try
                                    {
                                        StreamWriter sw = new StreamWriter("lab4_3.txt");
                                        string edit_exp;
                                        edit_exp = Console.ReadLine();
                                        sw.WriteLine(edit_exp);
                                        sw.Close();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                    expertDocumentWorker.EditDocument();
                                    break;
                                }
                            case "save":
                                {
                                    expertDocumentWorker.SaveDocument();
                                    break;
                                }
                            default:
                                Console.OutputEncoding = Encoding.UTF8;
                                Console.WriteLine("Sorry, this action is not available (:");
                                break;
                        }
                        break;
                    }

                default:
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("An error occurred, please try again");
                    break;
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The document is open");
        }

        public virtual void EditDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Document editing is available in the pro version");
        }

        public virtual void SaveDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Document saving is available in the pro version");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The document has been edited");
        }

        public override void SaveDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The document is saved in the old format, saving in new formats is available in the expert version");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The document is saved in a new format");
        }
    }
}
using System;

namespace TaskDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initialize: Console.WriteLine("Enter version");
            string versionProgram=Console.ReadLine();
               switch (versionProgram)
               {
                    case "basic":
                        DocumentProgram document = new DocumentProgram();
                        document.OpenDocument();
                        document.EditDocument();
                        document.SaveDocument();
                    break;
                    case "pro":
                        ProDocumentProgram pro = new ProDocumentProgram();
                        pro.OpenDocument();
                        pro.EditDocument();
                        pro.SaveDocument();
                    break;
                    case "expert":
                        ExpertDocumentProgram expert = new ExpertDocumentProgram();
                        expert.OpenDocument();
                        expert.EditDocument();
                        expert.SaveDocument();
                    break;
                    default:
                    Console.WriteLine("wrong version");
                    goto Initialize;
               }


        }
    }
}

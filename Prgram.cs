using System;
 
namespace SecureDocs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee name:");
            string name = Console.ReadLine();
 
            Console.WriteLine("Enter the Document Id:");
            string docId = Console.ReadLine();
 
            ProxyService proxy = new ProxyService();
            string result = proxy.GetDocumentAccess(docId, name);
 
            Console.WriteLine(result);
        }
    }
}

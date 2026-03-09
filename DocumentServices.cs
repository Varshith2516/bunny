using System;
 
namespace SecureDocs
{
    public class DocumentService : IDocumentAccess
    {
        public string GetDocumentAccess(string documentId, string name)
        {
            return name + " allowed to access the document";
        }
    }
}

using System;
 
namespace SecureDocs
{
    public interface IDocumentAccess
    {
        string GetDocumentAccess(string documentId, string name);
    }
}

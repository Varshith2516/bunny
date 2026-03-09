using System;
using System.Collections.Generic;
 
namespace SecureDocs
{
    public class ProxyService : IDocumentAccess
    {
        private DocumentService _documentService = new DocumentService();
        private AuthenticationRepo _authRepo = new AuthenticationRepo();
 
        public string GetDocumentAccess(string documentId, string name)
        {
            List<Employee> authorizedEmployees = _authRepo.GetAuthorizedEmployees();
 
            foreach (var emp in authorizedEmployees)
            {
                // Case-sensitive comparison as per requirements
                if (emp.documentId == documentId && emp.employeeName == name)
                {
                    return _documentService.GetDocumentAccess(documentId, name);
                }
            }
 
            return "Unauthorized";
        }
    }
}

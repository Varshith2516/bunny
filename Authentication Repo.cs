using System;
using System.Collections.Generic;
 
namespace SecureDocs
{
    public class AuthenticationRepo
    {
        public List<Employee> GetAuthorizedEmployees()
        {
            List<Employee> authorizedList = new List<Employee>();
            authorizedList.Add(new Employee("D100", "Alice"));
            authorizedList.Add(new Employee("D101", "Bob"));
            authorizedList.Add(new Employee("D102", "Charlie"));
            return authorizedList;
        }
    }
}

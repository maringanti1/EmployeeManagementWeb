using System.Collections.Generic;

namespace EmployeeManagement.Web.UI.Models
{
    public class EmployeeManager
    {
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Employee> Employees { get; set; }
    }


}

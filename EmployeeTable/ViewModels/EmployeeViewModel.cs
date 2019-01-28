using EmployeeTable.Models.Entities;
using System.Collections.Generic;

namespace EmployeeTable.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }
        public List<Department> Departments { get; set; }   // list of departments to use the fk_departmentID
        public Employee Employee { get; set; }            // so, if i made the above, i need now to edit my view in index  e.Id will be e.employee.id

    }
}
using EmployeeTable.Models.Entities;
using System.Collections.Generic;

namespace EmployeeTable.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }
        public List<Department> Departments { get; set; }
    }
}
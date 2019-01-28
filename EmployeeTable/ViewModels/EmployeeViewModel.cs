using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeTable.Models.Entities;

namespace EmployeeTable.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }
        public List<Department> Departments { get; set; }
    }
}
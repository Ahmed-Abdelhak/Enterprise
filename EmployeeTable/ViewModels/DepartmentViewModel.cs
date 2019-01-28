using System.Collections.Generic;
using EmployeeTable.Models.Entities;

namespace EmployeeTable.ViewModels
{
    public class DepartmentViewModel
    {
        public List<Department> Departments { get; set; }
        public int Id { get; set; }
    }
}
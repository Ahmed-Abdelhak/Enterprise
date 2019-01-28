using EmployeeTable.Models.Entities;
using System.Collections.Generic;

namespace EmployeeTable.ViewModels
{
    public class EmployeeViewModel
    {

        // i want to send two different objects of two classes to the view of the same Action,
        //
        //  so i had to make a new Layer which  takes references of the two objects and then i will use this ModelView Class in my vew
        public List<Employee> Employees { get; set; }
        public int Id { get; set; }


        // to be able to use the Foreign key of the Department in the Employee to Add it in the "Add new Employee"
        public List<Department> Departments { get; set; }   // list of departments to use the fk_departmentID



        public Employee Employee { get; set; }            // so, if i made the above, i need now to edit my view in index  e.Id will be e.employee.id

    }
}
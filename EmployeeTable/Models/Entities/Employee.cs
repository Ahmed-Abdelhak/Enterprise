using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTable.Models.Entities
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        public Gender Gender { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Department Department { get; set; }          // don't forget to include a relationShip here

        [ForeignKey("Department")]
        public int Fk_DepartmentId { get; set; }     // just make a field for the ID


    }
}
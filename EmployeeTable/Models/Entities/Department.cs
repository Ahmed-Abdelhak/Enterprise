using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTable.Models.Entities
{

    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50)]  [Required]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
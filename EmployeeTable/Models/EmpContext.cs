using EmployeeTable.Models.Entities;

namespace EmployeeTable.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EmpContext : DbContext
    {
        // Your context has been configured to use a 'EmpContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmployeeTable.Models.EmpContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmpContext' 
        // connection string in the application configuration file.
        public EmpContext()
            : base("name=EmpContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }

    
}
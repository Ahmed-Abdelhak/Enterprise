using System.Collections.Generic;
using EmployeeTable.Models.Entities;

namespace EmployeeTable.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeTable.Models.EmpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeTable.Models.EmpContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
           // context.Employees.RemoveRange(
           //  new List<Employee>() { 
           //   new Employee() { Id = 1, Name = "Andrew ", Age = 22 },
           //   new Employee() { Id = 2, Name = "osama", Age = 25 },
           //   new Employee() { Id = 3, Name = "Ahmed", Age = 27 },
           //   new Employee() { Id = 4, Name = "Peters", Age = 29 },
           //   new Employee() { Id = 5, Name = "Mido", Age = 24 }
           //} );
            //
        }
    }
}

namespace EmployeeTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSalaryColumnInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Salary", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Salary");
        }
    }
}

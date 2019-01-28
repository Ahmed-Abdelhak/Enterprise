namespace EmployeeTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfDeptIsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Department", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Department", "Name", c => c.String(maxLength: 50));
        }
    }
}

namespace EmployeeTable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UIHint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Name", c => c.String(maxLength: 50));
        }
    }
}

namespace StaffService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                        Salary = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

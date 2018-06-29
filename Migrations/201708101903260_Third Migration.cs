namespace demo_school_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        createdAt = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            AddColumn("dbo.Courses", "createdAt", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Courses", "Department_DepartmentID", c => c.Int());
            AddColumn("dbo.Students", "createdAt", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Students", "Department_DepartmentID", c => c.Int());
            CreateIndex("dbo.Courses", "Department_DepartmentID");
            CreateIndex("dbo.Students", "Department_DepartmentID");
            AddForeignKey("dbo.Courses", "Department_DepartmentID", "dbo.Departments", "DepartmentID");
            AddForeignKey("dbo.Students", "Department_DepartmentID", "dbo.Departments", "DepartmentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Courses", "Department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_DepartmentID" });
            DropIndex("dbo.Courses", new[] { "Department_DepartmentID" });
            DropColumn("dbo.Students", "Department_DepartmentID");
            DropColumn("dbo.Students", "createdAt");
            DropColumn("dbo.Courses", "Department_DepartmentID");
            DropColumn("dbo.Courses", "createdAt");
            DropTable("dbo.Departments");
        }
    }
}

namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkOnJobs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Jobs", new[] { "Company_Id" });
            RenameColumn(table: "dbo.Jobs", name: "Company_Id", newName: "CompanyId");
            AlterColumn("dbo.Jobs", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Jobs", "CompanyId");
            AddForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Jobs", new[] { "CompanyId" });
            AlterColumn("dbo.Jobs", "CompanyId", c => c.Int());
            RenameColumn(table: "dbo.Jobs", name: "CompanyId", newName: "Company_Id");
            CreateIndex("dbo.Jobs", "Company_Id");
            AddForeignKey("dbo.Jobs", "Company_Id", "dbo.Companies", "Id");
        }
    }
}

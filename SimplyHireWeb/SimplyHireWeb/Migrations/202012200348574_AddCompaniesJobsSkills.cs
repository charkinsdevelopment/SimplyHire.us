namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompaniesJobsSkills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        YearsInBusiness = c.Int(nullable: false),
                        NumberOfEmployees = c.Int(nullable: false),
                        YearlyRevenue = c.Int(nullable: false),
                        CompanyLogoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        MinPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SkillLevel = c.Int(nullable: false),
                        Job_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id)
                .Index(t => t.Job_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Skills", new[] { "Job_Id" });
            DropIndex("dbo.Jobs", new[] { "Company_Id" });
            DropTable("dbo.Skills");
            DropTable("dbo.Jobs");
            DropTable("dbo.Companies");
        }
    }
}

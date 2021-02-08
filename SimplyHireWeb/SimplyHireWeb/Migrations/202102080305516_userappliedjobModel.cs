namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userappliedjobModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAppliedJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        JobId = c.Int(nullable: false),
                        ApplyDate = c.DateTime(nullable: false),
                        ApplicationStatus = c.Int(nullable: false),
                        Notes = c.String(),
                        DeniedReason = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAppliedJobs", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserAppliedJobs", "JobId", "dbo.Jobs");
            DropIndex("dbo.UserAppliedJobs", new[] { "JobId" });
            DropIndex("dbo.UserAppliedJobs", new[] { "UserId" });
            DropTable("dbo.UserAppliedJobs");
        }
    }
}

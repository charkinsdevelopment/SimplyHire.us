namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hey : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserSkills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        SkillId = c.Int(nullable: false),
                        SkillName = c.String(),
                        SkillLevel = c.Int(nullable: false),
                        YearsExperience = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}

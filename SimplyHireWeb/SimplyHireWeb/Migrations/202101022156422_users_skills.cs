namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users_skills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Skills", "YearsExperience", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "YearsExperience");
            DropTable("dbo.UserSkills");
        }
    }
}

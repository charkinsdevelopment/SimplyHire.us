namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsletter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsLetterSignUps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        NewsletterSentDate = c.DateTime(),
                        OptedOut = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewsLetterSignUps");
        }
    }
}

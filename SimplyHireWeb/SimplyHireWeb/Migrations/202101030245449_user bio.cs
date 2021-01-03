namespace SimplyHireWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userbio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Bio", c => c.String(maxLength: 160));
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            DropColumn("dbo.AspNetUsers", "Bio");
        }
    }
}

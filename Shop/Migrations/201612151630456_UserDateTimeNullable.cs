namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDateTimeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "CreateDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CreateDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}

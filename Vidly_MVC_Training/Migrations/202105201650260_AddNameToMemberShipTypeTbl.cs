namespace Vidly_MVC_Training.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMemberShipTypeTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}

namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncreaseDisplayNameLimitation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "DisplayName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "DisplayName", c => c.String(nullable: false, maxLength: 12));
        }
    }
}

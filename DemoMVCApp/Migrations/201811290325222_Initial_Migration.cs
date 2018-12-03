namespace DemoMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyApplication",
                c => new
                    {
                        MyApplicationID = c.Int(nullable: false, identity: true),
                        MyApplicationName = c.String(),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MyApplicationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyApplication");
        }
    }
}

namespace DemoMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_MyTestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyTestTable",
                c => new
                    {
                        MyTestTableID = c.String(nullable: false, maxLength: 128),
                        MyTestStringColumn = c.String(),
                    })
                .PrimaryKey(t => t.MyTestTableID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyTestTable");
        }
    }
}

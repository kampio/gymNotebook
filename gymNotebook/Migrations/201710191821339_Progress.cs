namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Progress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Progresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Single(nullable: false),
                        Biceps = c.Single(nullable: false),
                        Chest = c.Single(nullable: false),
                        Thigh = c.Single(nullable: false),
                        Calf = c.Single(nullable: false),
                        Waist = c.Single(nullable: false),
                        Shoulders = c.Single(nullable: false),
                        Neck = c.Single(nullable: false),
                        UserDataID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserDatas", t => t.UserDataID, cascadeDelete: true)
                .Index(t => t.UserDataID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Progresses", "UserDataID", "dbo.UserDatas");
            DropIndex("dbo.Progresses", new[] { "UserDataID" });
            DropTable("dbo.Progresses");
        }
    }
}

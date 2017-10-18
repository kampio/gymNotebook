namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Height = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Progres",
                c => new
                    {
                        DataID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Single(nullable: false),
                        Biceps = c.Single(nullable: false),
                        Chest = c.Single(nullable: false),
                        Thigh = c.Single(nullable: false),
                        Calf = c.Single(nullable: false),
                        Waist = c.Single(nullable: false),
                        Shoulders = c.Single(nullable: false),
                        Neck = c.Single(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DataID)
                .ForeignKey("dbo.UserDatas", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            AddColumn("dbo.AspNetUsers", "UserData_UserID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "UserData_UserID");
            AddForeignKey("dbo.AspNetUsers", "UserData_UserID", "dbo.UserDatas", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "UserData_UserID", "dbo.UserDatas");
            DropForeignKey("dbo.Progres", "UserID", "dbo.UserDatas");
            DropIndex("dbo.Progres", new[] { "UserID" });
            DropIndex("dbo.AspNetUsers", new[] { "UserData_UserID" });
            DropColumn("dbo.AspNetUsers", "UserData_UserID");
            DropTable("dbo.Progres");
            DropTable("dbo.UserDatas");
        }
    }
}

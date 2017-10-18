namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDataModel3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Progres", "UserID", "dbo.UserDatas");
            DropForeignKey("dbo.AspNetUsers", "UserData_UserID", "dbo.UserDatas");
            DropIndex("dbo.AspNetUsers", new[] { "UserData_UserID" });
            DropIndex("dbo.Progres", new[] { "UserID" });
            DropColumn("dbo.AspNetUsers", "UserData_UserID");
            DropTable("dbo.UserDatas");
            DropTable("dbo.Progres");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.DataID);
            
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
            
            AddColumn("dbo.AspNetUsers", "UserData_UserID", c => c.Int());
            CreateIndex("dbo.Progres", "UserID");
            CreateIndex("dbo.AspNetUsers", "UserData_UserID");
            AddForeignKey("dbo.AspNetUsers", "UserData_UserID", "dbo.UserDatas", "UserID");
            AddForeignKey("dbo.Progres", "UserID", "dbo.UserDatas", "UserID", cascadeDelete: true);
        }
    }
}

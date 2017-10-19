namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserData2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "UserData_Id", "dbo.UserDatas");
            DropIndex("dbo.AspNetUsers", new[] { "UserData_Id" });
            AddColumn("dbo.UserDatas", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserDatas", "UserId");
            AddForeignKey("dbo.UserDatas", "UserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.AspNetUsers", "UserData_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserData_Id", c => c.Int());
            DropForeignKey("dbo.UserDatas", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserDatas", new[] { "UserId" });
            DropColumn("dbo.UserDatas", "UserId");
            CreateIndex("dbo.AspNetUsers", "UserData_Id");
            AddForeignKey("dbo.AspNetUsers", "UserData_Id", "dbo.UserDatas", "Id");
        }
    }
}

namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Height = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserData_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "UserData_Id");
            AddForeignKey("dbo.AspNetUsers", "UserData_Id", "dbo.UserDatas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "UserData_Id", "dbo.UserDatas");
            DropIndex("dbo.AspNetUsers", new[] { "UserData_Id" });
            DropColumn("dbo.AspNetUsers", "UserData_Id");
            DropTable("dbo.UserDatas");
        }
    }
}

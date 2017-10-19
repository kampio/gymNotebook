namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingChanges2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Trainings", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Trainings", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainings", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Trainings", "ApplicationUser_Id");
            AddForeignKey("dbo.Trainings", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

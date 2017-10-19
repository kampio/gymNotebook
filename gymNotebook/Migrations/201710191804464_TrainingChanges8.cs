namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingChanges8 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Trainings", name: "ApplicationUser_Id", newName: "UserId");
            RenameIndex(table: "dbo.Trainings", name: "IX_ApplicationUser_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Trainings", name: "IX_UserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Trainings", name: "UserId", newName: "ApplicationUser_Id");
        }
    }
}

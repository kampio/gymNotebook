namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingChanges7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Trainings", name: "Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.Trainings", name: "IX_Id", newName: "IX_ApplicationUser_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Trainings", name: "IX_ApplicationUser_Id", newName: "IX_Id");
            RenameColumn(table: "dbo.Trainings", name: "ApplicationUser_Id", newName: "Id");
        }
    }
}

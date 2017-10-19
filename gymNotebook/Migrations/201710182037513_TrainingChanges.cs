namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainings", "UserID");
        }
    }
}

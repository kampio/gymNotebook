namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.TrainingSessions", "SessionName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingSessions", "SessionName", c => c.String());
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String());
        }
    }
}

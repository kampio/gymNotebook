namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        TrainingId = c.Int(nullable: false, identity: true),
                        TrainingName = c.String(),
                    })
                .PrimaryKey(t => t.TrainingId);
            
            CreateTable(
                "dbo.TrainingSessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        SessionName = c.String(),
                        Training_TrainingId = c.Int(),
                    })
                .PrimaryKey(t => t.SessionId)
                .ForeignKey("dbo.Trainings", t => t.Training_TrainingId)
                .Index(t => t.Training_TrainingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingSessions", "Training_TrainingId", "dbo.Trainings");
            DropIndex("dbo.TrainingSessions", new[] { "Training_TrainingId" });
            DropTable("dbo.TrainingSessions");
            DropTable("dbo.Trainings");
        }
    }
}

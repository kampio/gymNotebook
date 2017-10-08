namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Exercises_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        MusclePart = c.Int(nullable: false),
                        TrainingSession_SessionId = c.Int(),
                    })
                .PrimaryKey(t => t.ExerciseId)
                .ForeignKey("dbo.TrainingSessions", t => t.TrainingSession_SessionId)
                .Index(t => t.TrainingSession_SessionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exercises", "TrainingSession_SessionId", "dbo.TrainingSessions");
            DropIndex("dbo.Exercises", new[] { "TrainingSession_SessionId" });
            DropTable("dbo.Exercises");
        }
    }
}

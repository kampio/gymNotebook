namespace gymNotebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseID = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        MusclePartID = c.Int(nullable: false),
                        SessionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExerciseID)
                .ForeignKey("dbo.MuscleParts", t => t.MusclePartID, cascadeDelete: true)
                .ForeignKey("dbo.TrainingSessions", t => t.SessionID, cascadeDelete: true)
                .Index(t => t.MusclePartID)
                .Index(t => t.SessionID);
            
            CreateTable(
                "dbo.MuscleParts",
                c => new
                    {
                        MusclePartID = c.Int(nullable: false, identity: true),
                        MuscleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MusclePartID);
            
            CreateTable(
                "dbo.TrainingResults",
                c => new
                    {
                        ResultID = c.Int(nullable: false, identity: true),
                        NumberSeries = c.Int(nullable: false),
                        Repetitions = c.Int(nullable: false),
                        Weigth = c.Single(nullable: false),
                        Comments = c.String(),
                        Datetime = c.DateTime(nullable: false),
                        ExerciseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResultID)
                .ForeignKey("dbo.Exercises", t => t.ExerciseID, cascadeDelete: true)
                .Index(t => t.ExerciseID);
            
            CreateTable(
                "dbo.TrainingSessions",
                c => new
                    {
                        SessionID = c.Int(nullable: false, identity: true),
                        SessionName = c.String(nullable: false, maxLength: 50),
                        TrainingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionID)
                .ForeignKey("dbo.Trainings", t => t.TrainingID, cascadeDelete: true)
                .Index(t => t.TrainingID);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        TrainingID = c.Int(nullable: false, identity: true),
                        TrainingName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TrainingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingSessions", "TrainingID", "dbo.Trainings");
            DropForeignKey("dbo.Exercises", "SessionID", "dbo.TrainingSessions");
            DropForeignKey("dbo.TrainingResults", "ExerciseID", "dbo.Exercises");
            DropForeignKey("dbo.Exercises", "MusclePartID", "dbo.MuscleParts");
            DropIndex("dbo.TrainingSessions", new[] { "TrainingID" });
            DropIndex("dbo.TrainingResults", new[] { "ExerciseID" });
            DropIndex("dbo.Exercises", new[] { "SessionID" });
            DropIndex("dbo.Exercises", new[] { "MusclePartID" });
            DropTable("dbo.Trainings");
            DropTable("dbo.TrainingSessions");
            DropTable("dbo.TrainingResults");
            DropTable("dbo.MuscleParts");
            DropTable("dbo.Exercises");
        }
    }
}

using gymNotebook.Models;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace gymNotebook.Concrete
{
    public class TrainingContext : DbContext
    {
        public TrainingContext() : base("TrainingContext")
        {

        }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<TrainingResult> TrainingResults { get; set; }
        public DbSet<MusclePart> MuscleParts { get; set; }

    }


}
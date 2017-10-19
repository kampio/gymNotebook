using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gymNotebook.ViewModels
{
    public class SetTrainingViewModel
    {
        public string TrainingName { get; set; }
    }

    public class SetSessionViewModel
    {
        public string SessionName { get; set; }
    }

    public class SetExerciseViewModel
    {
        public string ExerciseName { get; set; }

        public string Description { get; set; }

        public string MusclePart { get; set; }
    }


    public class SetTrainingResultViewModel
    {

    }
}
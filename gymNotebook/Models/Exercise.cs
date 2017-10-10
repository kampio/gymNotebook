using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymNotebook.Models
{
    
    public class Exercise
    {
        [Key]
        public int ExerciseID { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Cwiczenia")]
        [Display(Name = "Cwiczenie"), StringLength(50)]
        public string ExerciseName { get; set; }

        [DataType(DataType.MultilineText), Display(Name = "Opis ćwiczenia")]
        public string Description { get; set; }

        public int MusclePartID { get; set; }

        public virtual MusclePart MusclePart { get; set; }

        public int SessionID { get; set; }

        public virtual TrainingSession TrainingSessions { get; set; }

        public virtual ICollection<TrainingResult> TrainingResults { get; set; }
    }
}
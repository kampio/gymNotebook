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
        public int ExerciseId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Cwiczenia")]
        [Display(Name = "Cwiczenie"), StringLength(50)]
        public string ExerciseName { get; set; }

        [DataType(DataType.MultilineText), Display(Name = "Opis ćwiczenia")]
        public string Description { get; set; }

        public MusclePart MusclePart { get; set; }

        public virtual TrainingSession TrainingSession { get; set; }
    }

    public enum MusclePart
    {
        Klatka,
        Plecy,
        Barki,
        Nogi,
        Łydki,
        Biceps,
        Triceps,
        Przedramiona,
        Brzuch
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymNotebook.Models
{
    public class TrainingResult
    {
        [Key]
        public int ResultID { get; set; }

        [Display(Name = "Numer Serii")]
        public int NumberSeries { get; set; }

        [Display(Name = "Powtórzenia")]
        public int Repetitions { get; set; }

        [Display(Name = "Ciężar")]
        public float Weigth { get; set; }

        [Display(Name = "Uwagi"), DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public DateTime Datetime { get; set; }

        public int ExerciseID { get; set; }

        public virtual Exercise Exercise { get; set; }

    }
}
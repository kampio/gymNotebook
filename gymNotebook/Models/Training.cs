using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace gymNotebook.Models
{
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Treningu"), Display(Name = "Trening"), StringLength(50)]
        public string TrainingName { get; set; }

        public virtual List<TrainingSession> TrainingSessions { get; set; }

        public Training()
        {
            this.TrainingSessions = new List<TrainingSession>();
        }
    }
}
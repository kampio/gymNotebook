using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace gymNotebook.Models
{
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Treningu"), Display(Name = "Trening"), StringLength(50)]
        public string TrainingName { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<TrainingSession> TrainingSessions { get; set; }

    }
}
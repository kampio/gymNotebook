using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gymNotebook.Models
{
    public class TrainingSession
    {
        [Key]
        public int SessionId { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Sesji"), Display(Name = "Nazwa sesji"), StringLength(50)]
        public string SessionName { get; set; }

        public virtual Training Training { get; set; }

        public virtual List<Exercise> Exercises { get; set; }

        public TrainingSession()
        {
            this.Exercises = new List<Exercise>();
        }
    }
}
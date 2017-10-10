using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gymNotebook.Models
{
    public class TrainingSession
    {
        [Key]
        public int SessionID { get; set; }

        [Required(ErrorMessage = "Wprowadz nazwę Sesji"), Display(Name = "Nazwa sesji"), StringLength(50)]
        public string SessionName { get; set; }

        public int TrainingID { get; set; }

        public virtual Training Training { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }

    }
}
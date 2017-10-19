using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymNotebook.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public float Height { get; set; }

        public virtual ICollection<Progress> Progress { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
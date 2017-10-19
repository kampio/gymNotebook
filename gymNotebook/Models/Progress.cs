using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymNotebook.Models
{
    public class Progress
    {
        [Key]
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public float Weight { get; set; }

        public float Biceps { get; set; }

        public float Chest { get; set; }

        public float Thigh { get; set; }

        public float Calf { get; set; }

        public float Waist { get; set; }

        public float Shoulders { get; set; }

        public float Neck { get; set; }

        public int UserDataID { get; set; }

        public virtual UserData UserData { get; set; }
    }
}
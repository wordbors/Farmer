using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Data.Models
{
    public class Work
    {
        public int ID { get; set; }

        public int WorkTypeID { get; set; }
        public WorkTypes WorkType { get; set; }

        // Декари или часове
        [Required]
        public decimal DoneWork { get; set; }

        // За час или на декър
        [Required]
        public decimal Rate { get; set; }

        
        public int PlaceID { get; set; }
        public Places Place { get; set; }
 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Data.Models
{
    public class Places
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string  Name { get; set; }

        [Required]
        public int VillageID { get; set; }
        public Villages Village { get; set; }

        public List<Work> Works { get; set; } = new List<Work>();
    }
}

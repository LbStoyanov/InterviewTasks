using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalTask.Models
{
    public class Engine
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Brand { get; set; }

        public decimal CubicCentimeters{ get; set; }


    }
}

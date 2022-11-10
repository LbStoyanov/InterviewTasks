using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalTask.Models
{
    public class Tire
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Width { get; set; }

        [Required]
        public int Heith { get; set; }

        [Required]
        public int SpeedIndex { get; set; }

        [Required]
        public int Pressure { get; set; }

        [Required]
        public int DOT { get; set; }
    }
}

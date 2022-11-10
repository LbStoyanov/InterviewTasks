using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalTask.Models
{
    public class Car
    {
        public Car()
        {
            this.Tires = new HashSet<Tire>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.GlobalConstants.CarBrandMaxLength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(GlobalConstants.GlobalConstants.CarModelMaxLength)]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(GlobalConstants.GlobalConstants.CarColorlMaxLength)]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [InverseProperty(nameof(Tire.Id))]
        public ICollection<Tire> Tires { get; set; }
    }
}

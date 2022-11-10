
using CarRentalSystem.GlobalConstants;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.GlobalConstants.CarBrandMaxLength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(GlobalConstants.GlobalConstants.CarBrandMaxLength)]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsAvailable { get; set; }   
    }
}

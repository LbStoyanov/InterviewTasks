using CarRentalTask.Data;
using CarRentalTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalTask.Controllers
{
    public class CarController
    {
        private RentalDbContext rentalDbContext;
        public CarController(RentalDbContext rentalDbContext)
        {
            this.rentalDbContext = rentalDbContext;
        }

        public void CreateCar(Car car)
        {
            rentalDbContext.Cars.Add(car);
            rentalDbContext.SaveChanges();
        }

        
        public void EditCar(int carId,decimal price)
        {
            var editedCar = rentalDbContext.Cars.FirstOrDefault(x => x.Id == carId);
            editedCar.Price = price;
            rentalDbContext.SaveChanges();
            
        }

        public List<Car> ListAllCars()
        {
            return rentalDbContext.Cars.ToList();
        }

        public string RentCar(int carId)
        {
            var searchedCar = rentalDbContext.Cars.First(x => x.Id == carId);

            if (searchedCar.IsAvailable)
            {
                searchedCar.IsAvailable = false;
                rentalDbContext.SaveChanges();
                return "Car is rented.";
            }
            else
            {
                return"Car is unavailable!";
            }
	
        }

        public bool CheckCarAvailability(int carId)
        {
            var searchedCar = rentalDbContext
                .Cars
                .First(C=>C.Id == carId);

            return searchedCar.IsAvailable;
      
        }
    }
}

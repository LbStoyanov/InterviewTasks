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

        public void EditCar(Car car)
        {
            var editedCar = rentalDbContext.Cars.FirstOrDefault(x => x.Id == car.Id);
            
        }

        public List<Car> ListAllCars()
        {
            return rentalDbContext.Cars;
        }

        public void RentCar()
        {

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

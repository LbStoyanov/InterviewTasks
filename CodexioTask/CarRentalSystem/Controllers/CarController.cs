using CarRentalSystem.Data;
using CarRentalSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarRentalDbContext _carRentalDbContext;

        public CarController(CarRentalDbContext carRentalDbContext)
        {
            this._carRentalDbContext = carRentalDbContext;
        }

        [HttpPost]
        [Route("create")]
        public string CreateCar(string brand,string model,decimal Price)
        {
            Car car = new Car
            {
                Brand = brand,
                Model = model,
                Price = Price,
                IsAvailable = true
               
            };
            //TODO: Move logic to sevice
            _carRentalDbContext.Cars.Add(car);
            _carRentalDbContext.SaveChanges();
            return "Car created!";
        }

        [HttpPost]
        [Route("edit")]
        public string EditCar(int carId,decimal price)
        {
            var searchedCar = _carRentalDbContext.Cars.FirstOrDefault(c => c.Id == carId);

            if (searchedCar == null)
            {
                return "Car does not exist!";
            }

            searchedCar.Price = price;
            _carRentalDbContext.SaveChanges();
            return "Car edited!";
        }

        [HttpGet]
        [Route("get-all")]
        public List<Car> GetAllCars() //TODO:Refactor using DTO
        {
            return _carRentalDbContext.Cars.ToList();
        }

        [HttpPost]
        [Route("rent")]
        public string RentCar(int carId)
        {
            var car = _carRentalDbContext.Cars.FirstOrDefault(c => c.Id == carId);

            if (car == null)
            {
                return "Car does not exist!";
            }

            if (!car.IsAvailable)
            {
                return "Car is not available!";
            }

            car.IsAvailable = false;
            _carRentalDbContext.SaveChanges();

            return "Car rented!";
        }

        [HttpGet]
        [Route("check-availability")]
        public string CheckAvailability(int carId)
        {
            var car = _carRentalDbContext.Cars.FirstOrDefault(c => c.Id == carId);

            if (car == null)
            {
                return "Car does not exist!";
            }

            if (!car.IsAvailable)
            {
                return "Car is not available!";
            }

            return "Car is available!";
        }
    }
}

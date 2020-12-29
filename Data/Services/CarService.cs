using System;
using System.Linq;
using System.Threading.Tasks;
using ParkingCar.Data.Domain;
using RazorPagesMovie.Data;

namespace ParkingCar.Data
{
    public class CarService
    {
        public CarContext _context;
        public CarService(CarContext context)
        {
            _context = context;
        }

        public async Task Create(string plate, string model, DateTime entrance)
        {
            Car car = new Car()
            {
                Plate = plate,
                Model = model,
                Entrance = entrance,
            };

            _context.Add(car);
            _context.SaveChanges();
        }
    }
}

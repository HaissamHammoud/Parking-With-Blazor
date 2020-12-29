using Microsoft.AspNetCore.Mvc;
using ParkingCar.Data;
using ParkingCar.Data.Domain;
using System;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BlazorCrud.Server.Controllers  
{  
    public class CarController : Controller 
    {
        private readonly CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }


        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCar(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _carService.Create(car.Plate, car.Model, DateTime.Now);
            return  Ok();
        }
    } 
}
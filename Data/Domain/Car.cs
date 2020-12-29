using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingCar.Data.Domain
{
    public class Car
    {
        [Key]
        public string Plate { get; set; }

        public string Model { get; set; }

        public DateTime Entrance { get; set; }

        public DateTime? Exit { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using ParkingCar.Data.Domain;

namespace RazorPagesMovie.Data
{
    public class CarContext : DbContext
    {
        public CarContext (
            DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
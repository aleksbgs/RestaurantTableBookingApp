using Microsoft.EntityFrameworkCore;
using RestaurantTableBookingApp.Core;
using RestaurantTableBookingApp.Data.ModelTemp;

namespace RestaurantTableBookingApp.Data
{
    public class RestaurantTableBookingDbContext : DbContext
    {
        public RestaurantTableBookingDbContext(DbContextOptions<RestaurantTableBookingDbContext> options) :
            base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<DiningTable> DiningTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantBranch> RestaurantBranches { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

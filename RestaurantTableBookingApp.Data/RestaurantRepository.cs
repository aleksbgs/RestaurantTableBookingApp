
using Microsoft.EntityFrameworkCore;
using RestaurantTableBookingApp.Core.ViewModels;

namespace RestaurantTableBookingApp.Data;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly RestaurantTableBookingDbContext _dbContext;


    public RestaurantRepository(RestaurantTableBookingDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<IEnumerable<RestaurantModel>> GetAllRestaurantsAsync()
    {
        var restaurants = await _dbContext.Restaurants
            .Select(r => new RestaurantModel
            {
                Id = r.Id,
                Name = r.Name,
                Address = r.Address,
                Phone = r.Phone,
                Email = r.Email,
                ImageUrl = r.ImageUrl
            })
            .ToListAsync();

        return restaurants;
    }
}
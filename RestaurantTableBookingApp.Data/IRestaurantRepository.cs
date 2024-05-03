using RestaurantTableBookingApp.Core.ViewModels;

namespace RestaurantTableBookingApp.Data;

public interface IRestaurantRepository
{
    Task<IEnumerable<RestaurantModel>> GetAllRestaurantsAsync();
}
using RestaurantTableBookingApp.Core.ViewModels;

namespace RestaurantTableBookingApp.Service;

public interface IRestaurantService
{
    Task<IEnumerable<RestaurantModel>> GetAllRestaurantsAsync();
}
using RestaurantTableBookingApp.Core.ViewModels;
using RestaurantTableBookingApp.Data;

namespace RestaurantTableBookingApp.Service;

public class RestaurantService:IRestaurantService
{

    private readonly IRestaurantRepository _restaurantRepository;

    public RestaurantService(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task<IEnumerable<RestaurantModel>> GetAllRestaurantsAsync()
    {
        return await _restaurantRepository.GetAllRestaurantsAsync();
    }

}
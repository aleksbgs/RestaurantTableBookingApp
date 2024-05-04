using RestaurantTableBookingApp.Core;
using RestaurantTableBookingApp.Core.ViewModels;

namespace RestaurantTableBookingApp.Data;

public interface IRestaurantRepository
{
    Task<IEnumerable<RestaurantModel>> GetAllRestaurantsAsync();
    Task<IEnumerable<RestaurantBranchModel>> GetRestaurantBranchsByRestaurantIdAsync(int restaurantId);
    Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId, DateTime date);
    Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId);
    
    Task<RestaurantReservationDetails> GetRestaurantReservationDetailsAsync(int timeSlotId);

    Task<User?> GetUserAsync(string emailId);
}
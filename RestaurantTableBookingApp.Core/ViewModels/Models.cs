using System.Runtime;

namespace RestaurantTableBookingApp.Core.ViewModels;

public partial class RestaurantModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? ImageUrl { get; set; }
}
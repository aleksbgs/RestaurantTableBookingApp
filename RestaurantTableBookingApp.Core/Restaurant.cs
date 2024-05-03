using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantTableBookingApp.Core;

public partial class Restaurant
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Required]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    [Required]
    public string Address { get; set; } = null!;

    [StringLength(20)]
    [Required]
    public string? Phone { get; set; }

    [StringLength(100)]
    [Required]
    public string? Email { get; set; }

    [StringLength(500)]
    [Required]
    public string? ImageUrl { get; set; }

    [InverseProperty("Restaurant")]
    public virtual ICollection<RestaurantBranch> RestaurantBranches { get; set; } = new List<RestaurantBranch>();
}

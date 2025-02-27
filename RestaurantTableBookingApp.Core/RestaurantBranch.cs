﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RestaurantTableBookingApp.Data.ModelTemp;

namespace RestaurantTableBookingApp.Core;

[Index("RestaurantId", Name = "IX_RestaurantBranches_RestaurantId")]
public partial class RestaurantBranch
{
    [Key]
    public int Id { get; set; }

    public int RestaurantId { get; set; }

    [StringLength(100)]
    [Required]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    [Required]
    public string Address { get; set; } = null!;

    [StringLength(20)]
    [Required]
    public string? Phone { get; set; }
    [Required]
    [StringLength(100)]
    public string? Email { get; set; }
    [Required]
    [StringLength(500)]
    public string? ImageUrl { get; set; }

    [InverseProperty("RestaurantBranch")]
    public virtual ICollection<DiningTable> DiningTables { get; set; } = new List<DiningTable>();

    [ForeignKey("RestaurantId")]
    [InverseProperty("RestaurantBranches")]
    public virtual Restaurant Restaurant { get; set; } = null!;
}

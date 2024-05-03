using System.CodeDom;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RestaurantTableBookingApp.Core.ViewModels;
using RestaurantTableBookingApp.Service;

namespace RestaurantTableBookingApp.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet("restaurants")]
    [ProducesResponseType(200, Type = typeof(List<RestaurantModel>))]
    public async Task<ActionResult> GetAllRestaurants()
    {
        var restaurants = await _restaurantService.GetAllRestaurantsAsync();
        return Ok(restaurants);
    }


}
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
    [ProducesResponseType(200, Type = typeof(IEnumerable<RestaurantModel>))]
    public async Task<ActionResult> GetAllRestaurants()
    {
        var restaurants = await _restaurantService.GetAllRestaurantsAsync();
        return Ok(restaurants);
    }

    [HttpGet("branches/{restaurantid}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<RestaurantBranchModel>))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<IEnumerable<RestaurantBranchModel>>> GetRestaurantBranchsByRestaurantIdAsync(
        int restaurantid)
    {
        var branches = await _restaurantService.GetRestaurantBranchsByRestaurantIdAsync(restaurantid);

        if (branches == null)
        {
            return NotFound();
        }


        return Ok(branches);
    }

    [HttpGet("diningtables/{branchId}/{date}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<DiningTableWithTimeSlotsModel>))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<IEnumerable<DiningTableWithTimeSlotsModel>>> GetDiningTablesByBranchAndDateAsync(
        int branchId, DateTime date)
    {
        var diningTables = await _restaurantService.GetDiningTablesByBranchAsync(branchId, date);
        if (diningTables == null)
        {
            return NotFound();
        }

        return Ok(diningTables);

    }
    [HttpGet("diningtables/{branchId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<DiningTableWithTimeSlotsModel>))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<IEnumerable<DiningTableWithTimeSlotsModel>>> GetDiningTablesByBranchAsync(
        int branchId)
    {
        var diningTables = await _restaurantService.GetDiningTablesByBranchAsync(branchId);
        if (diningTables == null)
        {
            return NotFound();
        }

        return Ok(diningTables);

    }




}
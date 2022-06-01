using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using probne2.DTO;
using probne2.Services;

namespace probne2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FireTrucksController : ControllerBase
{
    private readonly IFireTruckDbService _fireTruckDbService;

    public FireTrucksController(IFireTruckDbService fireTruckDbService)
    {
        _fireTruckDbService = fireTruckDbService;
    }
    
    [HttpPost("{idFireTruck:int}/AddToAction")]
    public async Task<IActionResult> AddFireTruckToAction(int idFireTruck, AddFireTruckToActionDTO dto)
    {
        await _fireTruckDbService.AddFireTruckToActionAsync(idFireTruck, dto);
        return Ok();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using probne2.Services;

namespace probne2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActionsController : ControllerBase
{
    private readonly IActionDbService _actionDbService;

    public ActionsController(IActionDbService actionDbService)
    {
        _actionDbService = actionDbService;
    }
    
    [HttpGet("{idAction:int}")]
    public async Task<IActionResult> GetAction(int idAction)
    {
        return Ok(await _actionDbService.GetAction(idAction));
    }
}
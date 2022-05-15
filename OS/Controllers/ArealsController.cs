using Microsoft.AspNetCore.Mvc;
using OS.Data;

namespace OS.Controllers;

[ApiController]
public class ArealsController : ControllerBase
{
    private readonly IArealStorage _context;

    public ArealsController(IArealStorage context)
    {
        _context = context;
    }

    [HttpGet("api/areals")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Areal>))]
    [ProducesResponseType(404)]
    public IActionResult GetAllAreals()
    {
        return Ok(_context.GetAllAreals());
    }
    
    [HttpGet("api/areals/{id}")]
    [ProducesResponseType(200, Type = typeof(Areal))]
    [ProducesResponseType(404)]
    public IActionResult GetArealById(int id)
    {
        var areal = _context.GetArealById(id);
        return areal == default ? NotFound(areal) : Ok(areal);
    }
    
    [HttpGet("api/areals/remove/{id}")]
    [ProducesResponseType(200, Type = typeof(Areal))]
    [ProducesResponseType(404)]
    public IActionResult RemoveArealById(int id)
    {
        var areal = _context.RemoveArealById(id);
        return areal == default ? NotFound(areal) : Ok(areal);
    }
}
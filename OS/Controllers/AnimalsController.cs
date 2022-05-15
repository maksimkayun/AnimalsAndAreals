using Microsoft.AspNetCore.Mvc;
using OS.Data;

namespace OS.Controllers;

[ApiController]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalStorage _context;

    public AnimalsController(IAnimalStorage context)
    {
        _context = context;
    }

    [HttpGet("api/animals")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Animal>))]
    [ProducesResponseType(404)]
    public IActionResult GetAll()
    {
        return Ok(_context.GetAllAnimals());
    }
}
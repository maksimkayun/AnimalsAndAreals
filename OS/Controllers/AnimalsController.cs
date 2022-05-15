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
    
    [HttpGet("api/animals/{id}")]
    [ProducesResponseType(200, Type = typeof(Animal))]
    [ProducesResponseType(404)]
    public IActionResult GetById(int id)
    {
        var animal = _context.GetAnimalById(id);
        return animal == default ? NotFound(animal) : Ok(animal);
    }
    
    [HttpGet("api/animals/byname/{name}")]
    [ProducesResponseType(200, Type = typeof(Animal))]
    [ProducesResponseType(404)]
    public IActionResult GetByName(string name)
    {
        var animal = _context.GetAnimalByName(name);
        return animal == default ? NotFound(animal) : Ok(animal);
    }
    
    [HttpGet("api/animals/remove/{id}")]
    [ProducesResponseType(200, Type = typeof(Animal))]
    [ProducesResponseType(404)]
    public IActionResult RemoveById(int id)
    {
        var animal = _context.RemoveAnimalById(id);
        return animal == default ? NotFound(animal) : Ok(animal);
    }
}
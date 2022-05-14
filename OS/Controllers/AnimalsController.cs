﻿using Microsoft.AspNetCore.Mvc;
using OS.Data;

namespace OS.Controllers;

[ApiController]
[Route("[controller]")]

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
    public IEnumerable<Animal> GetAll()
    {
        return _context.GetAllAnimals();
    }
}
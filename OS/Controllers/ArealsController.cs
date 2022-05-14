using Microsoft.AspNetCore.Mvc;
using OS.Data;

namespace OS.Controllers;

[ApiController]
[Route("[controller]")]
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
    public IEnumerable<Areal> GetAllAreals()
    {
        return _context.GetAllAreals();
    }
}
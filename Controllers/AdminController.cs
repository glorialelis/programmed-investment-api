using Microsoft.AspNetCore.Mvc;
using CompraProgramada.Application.Services;

namespace CompraProgramada.API.Controllers;

[ApiController]
[Route("admin")]
public class AdminController : ControllerBase
{
    private readonly ClienteService _service;

    public AdminController(ClienteService service)
    {
        _service = service;
    }

    // GET /admin/cesta
    [HttpGet("cesta")]
    public IActionResult Cesta()
    {
        var cesta = _service.ObterCestaRecomendada();
        return Ok(cesta);
    }
}
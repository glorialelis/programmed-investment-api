using Microsoft.AspNetCore.Mvc;
using CompraProgramada.Application;
using CompraProgramada.Application.Services;

namespace CompraProgramada.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdesaoController : ControllerBase
{
    private readonly AdesaoService _adesaoService;

    public AdesaoController(AdesaoService adesaoService)
    {
        _adesaoService = adesaoService;
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] AdesaoRequest request)
    {
        var adesao = await _adesaoService.CriarAdesao(
            request.Nome,
            request.Email,
            request.ValorMensal
        );

        return Ok(adesao);
    }
}
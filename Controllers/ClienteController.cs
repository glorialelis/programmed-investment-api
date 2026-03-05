using CompraProgramada.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using CompraProgramada.Application.Services;

namespace CompraProgramada.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public IActionResult Listar()
    {
        var clientes = _clienteService.Listar();
        return Ok(clientes);
    }

    [HttpPost]
    public IActionResult Criar([FromBody] CriarClienteRequest request)
    {
        var cliente = _clienteService.Criar(request.Nome, request.Email);
        return Created("", cliente);
    }
}
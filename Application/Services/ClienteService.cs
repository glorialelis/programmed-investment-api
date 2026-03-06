namespace CompraProgramada.Application.Services;

using CompraProgramada.Domain.Entities;
using CompraProgramada.Infrastructure.Data;



public class ClienteService
{
    private readonly AppDbContext _context;

    public ClienteService(AppDbContext context)
    {
        _context = context;
    }

    public List<Cliente> Listar()
    {
        return _context.Clientes.ToList();
    }

    public Cliente Criar(string nome, string email)
    {
        var cliente = new Cliente(nome, email);

        _context.Clientes.Add(cliente);
        _context.SaveChanges();

        return cliente;
    }

    public object ObterCestaRecomendada()
{
    return new[]
    {
        new { Ativo = "PETR4", Peso = 0.4 },
        new { Ativo = "VALE3", Peso = 0.3 },
        new { Ativo = "ITUB4", Peso = 0.3 }
    };
}
}
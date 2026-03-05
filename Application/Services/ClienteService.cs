using CompraProgramada.Application.Services;

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
}
using CompraProgramada.Domain.Entities;
using CompraProgramada.Infrastructure.Data;
using CompraProgramada.Infrastructure.Messaging;

namespace CompraProgramada.Application.Services;

public class AdesaoService
{
    private readonly AppDbContext _context;
    private readonly KafkaProducer _producer;

    public AdesaoService(AppDbContext context, KafkaProducer producer)
    {
        _context = context;
        _producer = producer;
    }

    public async Task<Adesao> CriarAdesao(string nome, string email, decimal valorMensal)
    {
        var cliente = new Cliente(nome, email);

        _context.Clientes.Add(cliente);

        var adesao = new Adesao(cliente.Id, valorMensal);

        _context.Adesoes.Add(adesao);

        _context.SaveChanges();

        await _producer.EnviarMensagem("adesao-criada", adesao);

        return adesao;
    }
}
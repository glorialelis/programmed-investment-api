namespace CompraProgramada.Domain.Entities;

public class Adesao
{
    public Guid Id { get; private set; }
    public Guid ClienteId { get; private set; }
    public decimal ValorMensal { get; private set; }
    public DateTime DataCriacao { get; private set; }

    private Adesao() { }

    public Adesao(Guid clienteId, decimal valorMensal)
    {
        Id = Guid.NewGuid();
        ClienteId = clienteId;
        ValorMensal = valorMensal;
        DataCriacao = DateTime.UtcNow;
    }
}
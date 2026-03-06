namespace CompraProgramada.Domain.Entities;

public class Cliente
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public DateTime DataCadastro { get; private set; }

    // Construtor usado pelo EF
    private Cliente() { }

    public Cliente(string nome, string email)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        DataCadastro = DateTime.UtcNow;
    }
}
using Microsoft.EntityFrameworkCore;
using CompraProgramada.Domain.Entities;

namespace CompraProgramada.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Adesao> Adesoes { get; set; }
}
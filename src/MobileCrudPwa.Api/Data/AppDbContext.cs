using MobileCrudPwa.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MobileCrudPwa.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuração da entidade Produto
        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(p => p.Preco)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            entity.Property(p => p.Estoque)
                .IsRequired()
                .HasDefaultValue(0);

            entity.Property(p => p.DataCriacao)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(p => p.DataAtualizacao)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}

using MobileCrudPwa.Api.Models;

namespace MobileCrudPwa.Api.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext db)
    {
        //cria base de dados e tabelas se elas ainda não existem
        db.Database.EnsureCreated();

        //se tem produtos, ele não faz nada
        if (db.Produtos.Any()) return;

        var produtos = new Produto[]
        {
            new Produto
            {
                Nome = "Notebook Dell",
                Preco = 3500.00m,
                Estoque = 10,
                DataCriacao = DateTime.UtcNow,
                DataAtualizacao = DateTime.UtcNow
            },
            new Produto
            {
                Nome = "Mouse Logitech",
                Preco = 89.90m,
                Estoque = 50,
                DataCriacao = DateTime.UtcNow,
                DataAtualizacao = DateTime.UtcNow
            },
            new Produto
            {
                Nome = "Teclado Mecânico",
                Preco = 299.90m,
                Estoque = 25,
                DataCriacao = DateTime.UtcNow,
                DataAtualizacao = DateTime.UtcNow
            },
            new Produto
            {
                Nome = "Monitor 24\"",
                Preco = 799.90m,
                Estoque = 15,
                DataCriacao = DateTime.UtcNow,
                DataAtualizacao = DateTime.UtcNow
            }
        };

        db.Produtos.AddRange(produtos);
        db.SaveChanges();
    }
}d
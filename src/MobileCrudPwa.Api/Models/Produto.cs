namespace MobileCrudPwa.Api.Models;

public class Produto
{
    public int Id { get; set; }
    
    public string Nome { get; set; } = string.Empty;
    
    public decimal Preco { get; set; }
    
    public int Estoque { get; set; }
    
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    
    public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;
}
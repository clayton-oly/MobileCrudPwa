namespace MobileCrudPwa.Client.DTOs;

public class ProdutoDTO
{
    public int Id { get; set; }
    
    public string Nome { get; set; } = string.Empty;
    
    public decimal Preco { get; set; }
    
    public int Estoque { get; set; }
    
    public DateTime DataCriacao { get; set; }
    
    public DateTime DataAtualizacao { get; set; }
}
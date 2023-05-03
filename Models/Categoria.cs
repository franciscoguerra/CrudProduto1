using CrudProduto.Enums;

namespace CrudProduto.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public StatusCadastro Status { get; set; }
        public virtual List<Produto>? Produtos { get; set; }
        
    }
}

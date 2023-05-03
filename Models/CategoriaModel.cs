using CrudProduto.Enums;

namespace CrudProduto.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public StatusCadastro Status { get; set; }
        public virtual List<ProdutoModel>? CategoriaProduto { get; set; }
        
    }
}

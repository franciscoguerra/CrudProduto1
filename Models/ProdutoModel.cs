using CrudProduto.Enums;

namespace CrudProduto.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public StatusCadastro Status { get; set; }
        public int? MarcaProdutoId { get; set; }
        public MarcaModel? MarcaModel { get; set; }
        public int? CategoriaProdutoId { get; set; }
        public  CategoriaModel? CategoriaModel { get; set; }
    }
}

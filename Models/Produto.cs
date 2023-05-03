using CrudProduto.Enums;

namespace CrudProduto.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public StatusCadastro Status { get; set; }
        public int? MarcaId { get; set; }
        public Marca? Marca { get; set; }
        public int? CategoriaId { get; set; }
        public  Categoria? Categoria { get; set; }
    }
}

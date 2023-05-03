using CrudProduto.Enums;

namespace CrudProduto.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public StatusCadastro Status { get; set; }
        public virtual List<Produto>? Produtos { get; set; }
        
    }
}

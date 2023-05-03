using CrudProduto.Models;

namespace CrudProduto.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<ProdutoModel>> BuscarTodosProdutos();
        Task<ProdutoModel> BuscarPorId(int id);
        Task<ProdutoModel> AdicionarProduto(ProdutoModel produto);
        Task<ProdutoModel> AtualizarProduto(ProdutoModel protudo, int id);
        Task<bool> ApagarProduto(int id);

    }
}

using CrudProduto.Models;

namespace CrudProduto.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<Produto>> BuscarTodosProdutos();
        Task<Produto> BuscarPorId(int id);
        Task<Produto> AdicionarProduto(Produto produto);
        Task<Produto> AtualizarProduto(Produto protudo, int id);
        Task<bool> ApagarProduto(int id);

    }
}

using CrudProduto.Models;

namespace CrudProduto.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> BuscarTodasCategorias();
        Task<Categoria> BucarCategoriaId(int id);
        Task<Categoria> AdicionarCategoria(Categoria categoria);
        Task<Categoria> AtualizarCategoria(Categoria categoria, int id);
        Task<bool> DeletarCategoria(int id);

    }
}

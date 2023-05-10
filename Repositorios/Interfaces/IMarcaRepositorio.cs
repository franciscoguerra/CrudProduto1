using CrudProduto.Models;

namespace CrudProduto.Repositorios.Interfaces
{
    public interface IMarcaRepositorio
    {
        Task<List<Marca>> BuscarTodasMarcas();
        Task<Marca> BuscarMarcaId(int id);
        Task<Marca> AdiconarMarca(Marca marca);
        Task<Marca> AtualizarMarca(Marca marca, int id);
        Task<bool> DeleteMarca(int id);

    }
}

using CrudProduto.Data;
using CrudProduto.Models;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudProduto.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly CrudProdutoDbContext _dbContext;
        public CategoriaRepositorio(CrudProdutoDbContext crudProdutoDbContext)
        {
            _dbContext= crudProdutoDbContext;
        }

        public async Task<Categoria> BucarCategoriaId(int id)
        {
            return await _dbContext.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Categoria>> BuscarTodasCategorias()
        {
            return await _dbContext.Categoria.ToListAsync();
        }

        public async Task<Categoria> AdicionarCategoria(Categoria categoria)
        {
             await _dbContext.Categoria.AddAsync(categoria);
             await _dbContext.SaveChangesAsync();

            return categoria;
        }

        public async Task<Categoria> AtualizarCategoria(Categoria categoria, int id)
        {
            Categoria buscarCategoriaId = await BucarCategoriaId(id);
            if(buscarCategoriaId == null )
            {
                throw new Exception($" Categoria não encontrada para esse ID:{id}");
            }

            buscarCategoriaId.Nome = categoria.Nome;
            buscarCategoriaId.Status = categoria.Status;

             _dbContext.Update(buscarCategoriaId);
            await _dbContext.SaveChangesAsync();

            return buscarCategoriaId;
        }

       
        public async Task<bool> DeletarCategoria(int id)
        {
            Categoria buscarCategoriaId = await BucarCategoriaId(id);
            if (buscarCategoriaId == null )
            { 
                throw new Exception($"Não encontrado Categoria para esse ID:{id}");
            }

            _dbContext.Remove(buscarCategoriaId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}

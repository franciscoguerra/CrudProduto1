using CrudProduto.Data;
using CrudProduto.Models;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudProduto.Repositorios
{
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly CrudProdutoDbContext _dbContext;
        public MarcaRepositorio(CrudProdutoDbContext crudProdutoDbContext)
        {
            _dbContext = crudProdutoDbContext;
        }


        public async Task<Marca> BuscarMarcaId(int id)
        
        {
            return await _dbContext.Marca.FirstOrDefaultAsync(x => x.Id==id);
        }

        public async Task<List<Marca>> BuscarTodasMarcas()
        {
            return await _dbContext.Marca.ToListAsync();
        }

        public async Task<Marca> AdiconarMarca(Marca marca)
        {
            await _dbContext.Marca.AddAsync(marca);
            await _dbContext.SaveChangesAsync();

            return marca;
        }

        public async Task<Marca> AtualizarMarca(Marca marca, int id)
        {
            Marca buscarMarcaId = await BuscarMarcaId(id);
            if (buscarMarcaId == null)
            {
                throw new Exception($"Marca não encontrada para esse ID:{id}");
            }

            buscarMarcaId.Nome = marca.Nome;
            buscarMarcaId.Cnpj = marca.Cnpj;
            buscarMarcaId.Status = marca.Status;

            _dbContext.Marca.Update(buscarMarcaId);
           await _dbContext.SaveChangesAsync();

            return buscarMarcaId;
        }


        public async Task<bool> DeleteMarca(int id)
        {
            Marca buscarMarcaId = await BuscarMarcaId(id);

            if (buscarMarcaId == null)
            {
                throw new Exception($"não marca para esse ID:{id}");

            }

            _dbContext.Marca.Remove(buscarMarcaId);
            await _dbContext.SaveChangesAsync();
            return true;


        }

       
    }
}

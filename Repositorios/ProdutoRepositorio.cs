using CrudProduto.Data;
using CrudProduto.Models;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudProduto.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly CrudProdutoDbContext _dbContext;
        public ProdutoRepositorio(CrudProdutoDbContext crudProdutoDbContext)
        {
            _dbContext = crudProdutoDbContext;

        }
        public async Task<ProdutoModel> BuscarPorId(int id)
        {
            return await _dbContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProdutoModel>> BuscarTodosProdutos()
        {
            return await _dbContext.Produtos.ToListAsync();
        }
        public async Task<ProdutoModel> AdicionarProduto(ProdutoModel produto)
        {
           await _dbContext.Produtos.AddAsync(produto);
           await _dbContext.SaveChangesAsync();

            return produto;
        }

        public async Task<ProdutoModel> AtualizarProduto(ProdutoModel produto, int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);

            if (produtoPorId == null)
            {
                throw new Exception($"Produto para o ID:{id} não encontrado ");
            }

            produtoPorId.Nome= produto.Nome;
            produtoPorId.Valor = produto.Valor;
            produtoPorId.Quantidade= produto.Quantidade;
            produtoPorId.Status = produto.Status;
            produtoPorId.CategoriaProdutoId = produto.CategoriaProdutoId;
            produtoPorId.MarcaProdutoId = produto.MarcaProdutoId;

            

            _dbContext.Produtos.Update(produtoPorId);
           await _dbContext.SaveChangesAsync();

            return produtoPorId;
        }

        public async Task<bool> ApagarProduto(int id)
        {
            ProdutoModel buscarPorId = await BuscarPorId(id);
            if (buscarPorId == null)
            {
                throw new Exception($"Produto não encontrado para esse ID:{id}");
            }
            
            _dbContext.Produtos.Remove(buscarPorId);
           await _dbContext.SaveChangesAsync();
            return true;
        }

        

     
    }
}

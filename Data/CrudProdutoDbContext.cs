using CrudProduto.Data.Map;
using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudProduto.Data
{
    public class CrudProdutoDbContext : DbContext
    {
        public CrudProdutoDbContext(DbContextOptions<CrudProdutoDbContext> options)
            : base(options)
        {
        }
         
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<MarcaModel> Marca { get; set; }
        public DbSet<CategoriaModel> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

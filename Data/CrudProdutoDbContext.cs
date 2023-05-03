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
         
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

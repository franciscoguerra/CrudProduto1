using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudProduto.Data.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Status).IsRequired();
            builder.HasMany(x =>x.CategoriaProduto).WithOne(x =>x.CategoriaModel).HasForeignKey(x => x.CategoriaProdutoId);
        }
    }
}

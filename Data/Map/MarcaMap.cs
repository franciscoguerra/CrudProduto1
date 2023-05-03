using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudProduto.Data.Map
{
    public class MarcaMap : IEntityTypeConfiguration<MarcaModel>
    {
        public void Configure(EntityTypeBuilder <MarcaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Status).IsRequired();
            builder.HasMany(x =>x.MarcaProdutos).WithOne(x =>x.MarcaModel).HasForeignKey(x => x.MarcaProdutoId);
            
        }
    }
}

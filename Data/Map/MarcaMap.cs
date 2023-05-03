using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudProduto.Data.Map
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder <Marca> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Status).IsRequired();
            builder.HasMany(x => x.Produtos)
                .WithOne(x => x.Marca)
                .HasForeignKey(x => x.MarcaId);

        }
    }
}

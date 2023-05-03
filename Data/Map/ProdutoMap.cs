﻿using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudProduto.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Valor).HasColumnType("decimal(10,2)");
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.MarcaProdutoId).IsRequired();
            
            
        }
    }
}

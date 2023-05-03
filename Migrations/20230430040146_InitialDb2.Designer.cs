﻿// <auto-generated />
using System;
using CrudProduto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudProduto.Migrations
{
    [DbContext(typeof(CrudProdutoDbContext))]
    [Migration("20230430040146_InitialDb2")]
    partial class InitialDb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudProduto.Models.CategoriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("CrudProduto.Models.MarcaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("CrudProduto.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaProdutoId")
                        .HasColumnType("int");

                    b.Property<int?>("IdCategoria")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdMarca")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MarcaProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProdutoId");

                    b.HasIndex("MarcaProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CrudProduto.Models.ProdutoModel", b =>
                {
                    b.HasOne("CrudProduto.Models.CategoriaModel", "CategoriaProduto")
                        .WithMany("CategoriaProduto")
                        .HasForeignKey("CategoriaProdutoId");

                    b.HasOne("CrudProduto.Models.MarcaModel", "MarcaProduto")
                        .WithMany("MarcaProdutos")
                        .HasForeignKey("MarcaProdutoId");

                    b.Navigation("CategoriaProduto");

                    b.Navigation("MarcaProduto");
                });

            modelBuilder.Entity("CrudProduto.Models.CategoriaModel", b =>
                {
                    b.Navigation("CategoriaProduto");
                });

            modelBuilder.Entity("CrudProduto.Models.MarcaModel", b =>
                {
                    b.Navigation("MarcaProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}

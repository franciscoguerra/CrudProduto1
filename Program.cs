
using CrudProduto.Data;
using CrudProduto.Repositorios;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudProduto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //AddEntityFrameworkSqlServer()
            builder.Services
                .AddDbContext<CrudProdutoDbContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );
            builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            builder.Services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();
            builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
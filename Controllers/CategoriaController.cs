using CrudProduto.Models;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CrudProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public CategoriaController(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> BuscarTodasCategorias()
        {
            List<Categoria> categorias = await _categoriaRepositorio.BuscarTodasCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> BuscarCategoriaId(int id)
        {
            Categoria categoria = await _categoriaRepositorio.BucarCategoriaId(id);
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<ActionResult<Categoria>> AdicionarCategoria([FromBody] Categoria model)
        {
            Categoria categoria = await _categoriaRepositorio.AdicionarCategoria(model);
            return Ok(categoria);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Categoria>> AtualizarCategoria([FromBody] Categoria categoria, int id)
        {
            categoria.Id= id;
            Categoria c = await _categoriaRepositorio.AtualizarCategoria(categoria, id);
            return Ok(c);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> DeletarCategoria(int id)
        {
            bool apagado =  await _categoriaRepositorio.DeletarCategoria(id);
            return Ok(apagado);
        }
    }
}

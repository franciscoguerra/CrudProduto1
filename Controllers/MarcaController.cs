using CrudProduto.Models;
using CrudProduto.Repositorios;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepositorio _marcaRepositorio;

        public MarcaController(IMarcaRepositorio marcaRepositorio)
        {
            _marcaRepositorio= marcaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Marca>>> BuscarMarcas() 
        { 
            List<Marca> marcas =  await _marcaRepositorio.BuscarTodasMarcas();
            return Ok(marcas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Marca>> BucarMarcaId(int id)
        {
            Marca marca = await _marcaRepositorio.BuscarMarcaId(id);
            return Ok(marca);

        }

        [HttpPost]
        public async Task<ActionResult<Marca>> AdicionarMarca([FromBody] Marca model)
        {
            Marca marca = await _marcaRepositorio.AdiconarMarca(model);
            return Ok(marca);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Marca>> AtualizarMarca([FromBody] Marca marca, int id)
        {
            marca.Id = id;
            Marca m = await _marcaRepositorio.AtualizarMarca(marca, id);
            return Ok(m);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Marca>> DeletarMarca(int id)
        {
            bool apagado = await _marcaRepositorio.DeleteMarca(id);
            return Ok(apagado);
        }



    }
}


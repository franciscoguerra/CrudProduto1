using CrudProduto.Models;
using CrudProduto.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosProdutos()
        {
            List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarPorId(int id)
        {
            ProdutoModel produto = await _produtoRepositorio.BuscarPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> AdiconarProduto([FromBody] ProdutoModel produtoModel )
        {
           ProdutoModel produto = await _produtoRepositorio.AdicionarProduto(produtoModel);
            return Ok(produto);
        }
    }
}

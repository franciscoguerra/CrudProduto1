﻿using CrudProduto.Models;
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
        public async Task<ActionResult<List<Produto>>> BuscarTodosProdutos()
        {
            List<Produto> produtos = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> BuscarPorId(int id)
        {
            Produto produto = await _produtoRepositorio.BuscarPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> AdiconarProduto([FromBody] Produto model)
        {
           Produto produto = await _produtoRepositorio.AdicionarProduto(model);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> AtualizarProduto([FromBody] Produto produto, int id)
        {
            produto.Id = id;
            Produto p = await _produtoRepositorio.AtualizarProduto(produto, id);
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> ApagarProduto(int id)
        {
            bool apagado = await _produtoRepositorio.ApagarProduto(id);
                return Ok(apagado);
        }
    }
}

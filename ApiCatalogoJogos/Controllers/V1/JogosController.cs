using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ApiCatalogoJogos.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : Controller
    {
        //GET
        [HttpGet]
        public async Task<ActionResult<List<JogoViewModel>>> Obter()
        {
            return Ok();
        }
        
        //GET
        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<List<JogoViewModel>>> Obter(Guid guid)
        {
            return Ok();
        }
        
        //POST
        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> IserirJogo(JogoInputModel jogo)
        {
            return Ok();
        }
        
        //PUT
        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid guid, JogoInputModel jogo)
        {
            return Ok();
        }
        
        //PATCH
        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid guid, double preco, object jogo)
        {
            return Ok();
        }
        
        //DELETE
        [HttpDelete]
        public async Task<ActionResult> DeletarJogo(Guid guid)
        {
            return Ok();
        }
    }
}
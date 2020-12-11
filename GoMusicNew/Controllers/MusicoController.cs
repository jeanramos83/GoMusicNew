using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoMusicNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoMusicNew.Controllers
{
    public class MusicoController : Controller
    {
        public IActionResult Visualizar()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Lista todos os musicos");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Busca de Musico");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cadastro cadastro)
        {
            return Ok("Registrar Novo Musico");
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Cadastro cadastro)
        {
            return Ok("Musico atualizado com sucesso!");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok("Musico removido com sucesso!");
        } 
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoMusicNew.Dados.EntityFramework.Comum;
using GoMusicNew.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoMusicNew.Controllers
{
    public class EnderecoController : Controller
    {
        private Contexto contexto;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Busca(int id)
        {
            contexto = new Contexto();
            var db = new Endereco
            {
                IdEndereco = Convert.ToInt32(id)
            };
            var busca = contexto.Endereco.Find(db.IdEndereco);
            List<Endereco> teste = new List<Endereco>();
            teste.Add(busca);
            return View(teste);
        }
    }
}

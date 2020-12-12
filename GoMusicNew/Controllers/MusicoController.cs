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
    public class MusicoController : Controller
    {
        private Contexto contexto;

        public IActionResult Visualizar()
        {
            contexto = new Contexto();
            var db = contexto.Musico.ToList();
            return View(db);
        }

       
        public IActionResult Delete(int id,int id2)
        {
            contexto = new Contexto();
            var db2 = new Musico
            {
                IdMusico = Convert.ToInt32(id)
            };
            var busca2 = contexto.Musico.Find(db2.IdMusico);
            contexto.Musico.Remove(busca2);
            contexto.SaveChanges();
            var db = new Endereco
            {
                IdEndereco = Convert.ToInt32(id2)
            };
            var busca = contexto.Endereco.Find(db.IdEndereco);
            contexto.Endereco.Remove(busca);
            
            contexto.SaveChanges();
            return RedirectToAction("Visualizar", "Musico");
        }

        [HttpGet]
        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(IFormCollection collection)
            {
            contexto = new Contexto();
            //try
            //{
                var  endereco = new Endereco
                {
                    IdEndereco = Convert.ToInt32(collection["IdEndereco"]),
                    Rua = collection["Rua"],
                    Cidade = collection["Cidade"],
                    Numero = collection["Numero"],
                    Bairro = collection["Bairro"],
                    UF = collection["UF"],
                    IdMusico = Convert.ToInt32(collection["IdMusico"])
                };
                contexto.Endereco.Add(endereco);
                
                var musico = new Musico
                {
                    IdMusico = Convert.ToInt32(collection["IdMusico"]),
                    Nome = collection["Nome"],
                    CPF = collection["CPF"],
                    Idade = Convert.ToInt32(collection["Idade"]),
                    Telefone = collection["Telefone"],
                    Email = collection["Email"],
                    IdEndereco = Convert.ToInt32(collection["IdENdereco"]),
                    Instrumentos = collection["Instrumentos"],
                    DescricaoMusico = collection["DescricaoMusico"],
                    GeneroMusical = collection["GeneroMusical"]

                };
                contexto.Musico.Add(musico);
                contexto.SaveChanges();

                return RedirectToAction("Visualizar");
        //}
        //    catch
        //    {
        //        return View();
   //         }
        }
    }
}

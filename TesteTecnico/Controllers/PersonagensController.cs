using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Models;

namespace TesteTecnico.Controllers
{
    public class PersonagensController : Controller
    {
        private readonly Conteudo conteudo;
        public PersonagensController(Conteudo conteudo)
        {
            this.conteudo = conteudo;
        }
        public IActionResult Index()
        {
            return View(this.conteudo.personagem.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Personagem());
        }
        [HttpPost]
        public IActionResult Create(Personagem personagem1)
        {
            if (ModelState.IsValid)
            {
                this.conteudo.personagem.Add(personagem1);
                this.conteudo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personagem1);
        }
        [HttpGet]
        public IActionResult Read(int id)
        {
            return View(conteudo.personagem.Find(id));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if(conteudo.personagem.Find(id) != null)
            {

            }
            return View(conteudo.personagem.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Personagem personagem2)
        {
            if (ModelState.IsValid)
            {
                this.conteudo.personagem.Update(personagem2);
                this.conteudo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personagem2);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(this.conteudo.personagem.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Personagem personagem3)
        {
            Personagem persona = this.conteudo.personagem.Find(personagem3.id);
            if (persona != null)
            {
                this.conteudo.personagem.Remove(persona);
                this.conteudo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persona);
        }
    }
}

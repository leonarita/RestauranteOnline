using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class RestauranteController : BaseController
    {
        private RestauranteDBEntities db = new RestauranteDBEntities();

        // GET: Restaurante
        public ActionResult Index()
        {
            var restaurantes = db.Restaurante.Include("Bairro").Include("Genero").ToList();
            return View(restaurantes);
        }

        public ActionResult Inserir()
        {
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome");
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Restaurante.Add(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante);
            return View(restaurante);
        }

        public ActionResult Alterar(int id)
        {
            Restaurante restaurante = db.Restaurante.Find(id);
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante);
            return View(restaurante);
        }

        [HttpPost]
        public ActionResult Alterar(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante);
            return View(restaurante);
        }

        public ActionResult Excluir(int id)
        {
            Restaurante restaurante = db.Restaurante.Find(id);
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante);
            return View(restaurante);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Restaurante restaurante = db.Restaurante.Find(id);
                db.Restaurante.Remove(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("ErroExcluir");
            }
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }
    }
}
using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class GeneroController : BaseController
    {
        private RestauranteDBEntities db = new RestauranteDBEntities();

        // GET: Genero
        public ActionResult Index()
        {
            var generos = db.Genero.ToList();
            return View(generos);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Genero.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genero);
        }

        public ActionResult Alterar(int id)
        {
            Genero genero = db.Genero.Find(id);
            return View(genero);
        }

        [HttpPost]
        public ActionResult Alterar(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genero).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genero);
        }

        public ActionResult Excluir(int id)
        {
            Genero genero = db.Genero.Find(id);
            return View(genero);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Genero genero = db.Genero.Find(id);
                db.Genero.Remove(genero);
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
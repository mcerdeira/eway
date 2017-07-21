using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _eway.DAL;
using _eway.Models;

namespace eway.Controllers
{
    [Authorize]
    public class ProductoCelularController : Controller
    {
        private CatalogoContext db = new CatalogoContext();

        public ActionResult Index(string SearchString)
        {
            if (SearchString == null || SearchString.Trim() == "")
            {
                return View(db.ProductoCelular.ToList());
            }
            else
            {
                return View(db.ProductoCelular.Where(p => p.Descripcion.Contains(SearchString)));
            }
        }

        public ActionResult Details(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoCelular productoCelular = db.ProductoCelular.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoCelular == null)
            {
                return HttpNotFound();
            }
            return View(productoCelular);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GLN,GTIN,Alto,Ancho,Categoria,ContenidoNeto,Descripcion,ID,Marca,PesoBruto,Profundo,Variedad,CamaraResolucion,CapacidadBateria,MemoriaExpandida,Procesador,Resolicion,ResolucionVideo,SistemaOperativo,TamanoPantalla,VelocidadInternet,VersionSistemaOperativo")] ProductoCelular productoCelular)
        {
            if (ModelState.IsValid)
            {
                db.Producto.Add(productoCelular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productoCelular);
        }

        public ActionResult Edit(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoCelular productoCelular = db.ProductoCelular.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoCelular == null)
            {
                return HttpNotFound();
            }
            return View(productoCelular);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GLN,GTIN,Alto,Ancho,Categoria,ContenidoNeto,Descripcion,ID,Marca,PesoBruto,Profundo,Variedad,CamaraResolucion,CapacidadBateria,MemoriaExpandida,Procesador,Resolicion,ResolucionVideo,SistemaOperativo,TamanoPantalla,VelocidadInternet,VersionSistemaOperativo")] ProductoCelular productoCelular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productoCelular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productoCelular);
        }

        public ActionResult Delete(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoCelular productoCelular = db.ProductoCelular.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoCelular == null)
            {
                return HttpNotFound();
            }
            return View(productoCelular);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string GLN, string GTIN)
        {
            ProductoCelular productoCelular = db.ProductoCelular.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            db.Producto.Remove(productoCelular);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

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
    public class ProductoAireAcondicionadoController : Controller
    {
        private CatalogoContext db = new CatalogoContext();

        public ActionResult Index(string SearchString)
        {
            if (SearchString == null || SearchString.Trim() == "")
            {
                return View(db.ProductoAireAcondicionado.ToList());
            }
            else
            {
                return View(db.ProductoAireAcondicionado.Where(p => p.Descripcion.Contains(SearchString)));
            }
        }

        public ActionResult Details(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoAireAcondicionado productoAireAcondicionado = db.ProductoAireAcondicionado.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoAireAcondicionado == null)
            {
                return HttpNotFound();
            }
            return View(productoAireAcondicionado);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GLN,GTIN,Alto,Ancho,Categoria,ContenidoNeto,Descripcion,ID,Marca,PesoBruto,Profundo,Variedad,AltoExterior,AnchoExterior,Autolimpiante,DeflectorAire,DisplayLSD,EficienciaEnergeticaCalor,EficienciaEnergeticaFrio,FrigoriasCalor,FrigoriasFrio,FuncionAutomatico,FuncionDeshumificador,FuncionTurbo,FuncionVentilacion,PotenciaCalefaccion,PotenciaRefrigeracion,ProfundidadExterior,Sleep,TamanoAmbienteRecom,Timer,TipoClimatizacion,Wifi")] ProductoAireAcondicionado productoAireAcondicionado)
        {
            if (ModelState.IsValid)
            {
                db.Producto.Add(productoAireAcondicionado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productoAireAcondicionado);
        }

        public ActionResult Edit(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoAireAcondicionado productoAireAcondicionado = db.ProductoAireAcondicionado.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoAireAcondicionado == null)
            {
                return HttpNotFound();
            }
            return View(productoAireAcondicionado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GLN,GTIN,Alto,Ancho,Categoria,ContenidoNeto,Descripcion,ID,Marca,PesoBruto,Profundo,Variedad,AltoExterior,AnchoExterior,Autolimpiante,DeflectorAire,DisplayLSD,EficienciaEnergeticaCalor,EficienciaEnergeticaFrio,FrigoriasCalor,FrigoriasFrio,FuncionAutomatico,FuncionDeshumificador,FuncionTurbo,FuncionVentilacion,PotenciaCalefaccion,PotenciaRefrigeracion,ProfundidadExterior,Sleep,TamanoAmbienteRecom,Timer,TipoClimatizacion,Wifi")] ProductoAireAcondicionado productoAireAcondicionado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productoAireAcondicionado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productoAireAcondicionado);
        }

        public ActionResult Delete(string GLN, string GTIN)
        {
            if (GLN == null || GTIN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoAireAcondicionado productoAireAcondicionado = db.ProductoAireAcondicionado.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            if (productoAireAcondicionado == null)
            {
                return HttpNotFound();
            }
            return View(productoAireAcondicionado);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string GLN, string GTIN)
        {
            ProductoAireAcondicionado productoAireAcondicionado = db.ProductoAireAcondicionado.FirstOrDefault(p => p.GLN == GLN && p.GTIN == GTIN);
            db.Producto.Remove(productoAireAcondicionado);
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

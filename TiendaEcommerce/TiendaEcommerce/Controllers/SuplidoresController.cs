using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaEcommerce;

namespace TiendaEcommerce.Controllers
{
    public class SuplidoresController : Controller
    {
        private EcommerceEntities db = new EcommerceEntities();

        // GET: Suplidores
        public ActionResult Index()
        {
            return View(db.Suplidores.ToList());
        }

        // GET: Suplidores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplidores suplidores = db.Suplidores.Find(id);
            if (suplidores == null)
            {
                return HttpNotFound();
            }
            return View(suplidores);
        }

        // GET: Suplidores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suplidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Categoria,Marca,Telefono,Email")] Suplidores suplidores)
        {
            if (ModelState.IsValid)
            {
                suplidores.Fecha_Afiliacion = DateTime.Now.Date;
                db.Suplidores.Add(suplidores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suplidores);
        }

        // GET: Suplidores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplidores suplidores = db.Suplidores.Find(id);
            if (suplidores == null)
            {
                return HttpNotFound();
            }
            return View(suplidores);
        }

        // POST: Suplidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Categoria,Fecha_Afiliacion,Marca,Telefono,Email")] Suplidores suplidores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(suplidores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suplidores);
        }

        // GET: Suplidores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suplidores suplidores = db.Suplidores.Find(id);
            if (suplidores == null)
            {
                return HttpNotFound();
            }
            return View(suplidores);
        }

        // POST: Suplidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Suplidores suplidores = db.Suplidores.Find(id);
            db.Suplidores.Remove(suplidores);
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

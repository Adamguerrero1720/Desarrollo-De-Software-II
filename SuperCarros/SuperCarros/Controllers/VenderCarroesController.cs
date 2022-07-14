using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuperCarros;

namespace SuperCarros.Controllers
{
    public class VenderCarroesController : Controller
    {
        private SuperCarrosEntities db = new SuperCarrosEntities();

        // GET: VenderCarroes
        public ActionResult Index()
        {
            return View(db.VenderCarroes.ToList());
        }

        // GET: VenderCarroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VenderCarro venderCarro = db.VenderCarroes.Find(id);
            if (venderCarro == null)
            {
                return HttpNotFound();
            }
            return View(venderCarro);
        }

        // GET: VenderCarroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VenderCarroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre_Dueño,Telefono_Dueño,Estado,Marca,Modelo,Tipo,Precio,Transmision,Millaje,Tracción,Combustible,Puertas,Pasajeros,Lugar,Imagen_Vehiculo,Carro_Id")] VenderCarro venderCarro)
        {
            if (ModelState.IsValid)
            {
                venderCarro.Año = DateTime.Now.Date;
                db.VenderCarroes.Add(venderCarro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(venderCarro);
        }

        // GET: VenderCarroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VenderCarro venderCarro = db.VenderCarroes.Find(id);
            if (venderCarro == null)
            {
                return HttpNotFound();
            }
            return View(venderCarro);
        }

        // POST: VenderCarroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nombre_Dueño,Telefono_Dueño,Estado,Marca,Modelo,Tipo,Año,Precio,Transmision,Millaje,Tracción,Combustible,Puertas,Pasajeros,Lugar,Imagen_Vehiculo,Carro_Id")] VenderCarro venderCarro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venderCarro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(venderCarro);
        }

        // GET: VenderCarroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VenderCarro venderCarro = db.VenderCarroes.Find(id);
            if (venderCarro == null)
            {
                return HttpNotFound();
            }
            return View(venderCarro);
        }

        // POST: VenderCarroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VenderCarro venderCarro = db.VenderCarroes.Find(id);
            db.VenderCarroes.Remove(venderCarro);
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

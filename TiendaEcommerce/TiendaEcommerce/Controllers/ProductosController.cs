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
    public class ProductosController : Controller
    {
        private EcommerceEntities db = new EcommerceEntities();

        // GET: Productos
        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.Categorias).Include(p => p.Suplidores);
            return View(productos.ToList());
        }

        // GET: Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            ViewBag.Categoria_Id = new SelectList(db.Categorias, "Id", "Nombre_Categoria");
            ViewBag.Suplidor_Id = new SelectList(db.Suplidores, "Id", "Nombre_Categoria");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Producto,Precio,Cantidad_Disponible,Suplidor_Id,Suplidor,Categoria_Id")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                productos.Fecha_Llegaron = DateTime.Now.Date;
                db.Productos.Add(productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categoria_Id = new SelectList(db.Categorias, "Id", "Nombre_Categoria", productos.Categoria_Id);
            ViewBag.Suplidor_Id = new SelectList(db.Suplidores, "Id", "Nombre_Categoria", productos.Suplidor_Id);
            return View(productos);
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categoria_Id = new SelectList(db.Categorias, "Id", "Nombre_Categoria", productos.Categoria_Id);
            ViewBag.Suplidor_Id = new SelectList(db.Suplidores, "Id", "Nombre_Categoria", productos.Suplidor_Id);
            return View(productos);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Producto,Precio,Cantidad_Disponible,Suplidor_Id,Suplidor,Categoria_Id,Fecha_Llegaron")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categoria_Id = new SelectList(db.Categorias, "Id", "Nombre_Categoria", productos.Categoria_Id);
            ViewBag.Suplidor_Id = new SelectList(db.Suplidores, "Id", "Nombre_Categoria", productos.Suplidor_Id);
            return View(productos);
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Productos productos = db.Productos.Find(id);
            db.Productos.Remove(productos);
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

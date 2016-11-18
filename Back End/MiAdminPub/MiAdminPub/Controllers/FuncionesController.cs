using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiAdminPub;
using MiAdminPub.Models;

namespace MiAdminPub.Controllers
{
    public class FuncionesController : Controller
    {
        private MiAdminPubContext db = new MiAdminPubContext();

        // GET: Funciones
        public ActionResult Index()
        {
            return View(db.Funciones.ToList());
        }

        // GET: Funciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcion funcion = db.Funciones.Find(id);
            if (funcion == null)
            {
                return HttpNotFound();
            }
            return View(funcion);
        }

        // GET: Funciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuncionId,Nombre")] Funcion funcion)
        {
            if (ModelState.IsValid)
            {
                db.Funciones.Add(funcion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcion);
        }

        // GET: Funciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcion funcion = db.Funciones.Find(id);
            if (funcion == null)
            {
                return HttpNotFound();
            }
            return View(funcion);
        }

        // POST: Funciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuncionId,Nombre")] Funcion funcion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcion);
        }

        // GET: Funciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcion funcion = db.Funciones.Find(id);
            if (funcion == null)
            {
                return HttpNotFound();
            }
            return View(funcion);
        }

        // POST: Funciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcion funcion = db.Funciones.Find(id);
            db.Funciones.Remove(funcion);
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

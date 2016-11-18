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
    public class RecaudacionesController : Controller
    {
        private MiAdminPubContext db = new MiAdminPubContext();

        // GET: Recaudaciones
        public ActionResult Index()
        {
            return View(db.Recaudaciones.ToList());
        }

        // GET: Recaudaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recaudacion recaudacion = db.Recaudaciones.Find(id);
            if (recaudacion == null)
            {
                return HttpNotFound();
            }
            return View(recaudacion);
        }

        // GET: Recaudaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recaudaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecaudacionId,Fecha,Monto")] Recaudacion recaudacion)
        {
            if (ModelState.IsValid)
            {
                db.Recaudaciones.Add(recaudacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recaudacion);
        }

        // GET: Recaudaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recaudacion recaudacion = db.Recaudaciones.Find(id);
            if (recaudacion == null)
            {
                return HttpNotFound();
            }
            return View(recaudacion);
        }

        // POST: Recaudaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecaudacionId,Fecha,Monto")] Recaudacion recaudacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recaudacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recaudacion);
        }

        // GET: Recaudaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recaudacion recaudacion = db.Recaudaciones.Find(id);
            if (recaudacion == null)
            {
                return HttpNotFound();
            }
            return View(recaudacion);
        }

        // POST: Recaudaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recaudacion recaudacion = db.Recaudaciones.Find(id);
            db.Recaudaciones.Remove(recaudacion);
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

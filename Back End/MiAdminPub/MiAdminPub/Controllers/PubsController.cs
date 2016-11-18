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
    public class PubsController : Controller
    {
        private MiAdminPubContext db = new MiAdminPubContext();

        // GET: Pubs
        public ActionResult Index()
        {
            return View(db.Pubs.ToList());
        }

        // GET: Pubs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pub pub = db.Pubs.Find(id);
            if (pub == null)
            {
                return HttpNotFound();
            }
            return View(pub);
        }

        // GET: Pubs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PubId,Nombre,LicenciaFiscal,Domicilio,FechaApertura,Horario,DiasApertura")] Pub pub)
        {
            if (ModelState.IsValid)
            {
                db.Pubs.Add(pub);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pub);
        }

        // GET: Pubs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pub pub = db.Pubs.Find(id);
            if (pub == null)
            {
                return HttpNotFound();
            }
            return View(pub);
        }

        // POST: Pubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PubId,Nombre,LicenciaFiscal,Domicilio,FechaApertura,Horario,DiasApertura")] Pub pub)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pub).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pub);
        }

        // GET: Pubs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pub pub = db.Pubs.Find(id);
            if (pub == null)
            {
                return HttpNotFound();
            }
            return View(pub);
        }

        // POST: Pubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pub pub = db.Pubs.Find(id);
            db.Pubs.Remove(pub);
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

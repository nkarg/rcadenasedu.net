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
    public class TitularesController : Controller
    {
        private MiAdminPubContext db = new MiAdminPubContext();

        // GET: Titulares
        public ActionResult Index()
        {
            return View(db.Titulares.ToList());
        }

        // GET: Titulares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titulares.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // GET: Titulares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titulares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonaId,Nombre,Dni,Domicilio,CuilTitular")] Titular titular)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(titular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titular);
        }

        // GET: Titulares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titulares.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // POST: Titulares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonaId,Nombre,Dni,Domicilio,CuilTitular")] Titular titular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titular);
        }

        // GET: Titulares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titular titular = db.Titulares.Find(id);
            if (titular == null)
            {
                return HttpNotFound();
            }
            return View(titular);
        }

        // POST: Titulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Titular titular = db.Titulares.Find(id);
            db.Personas.Remove(titular);
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

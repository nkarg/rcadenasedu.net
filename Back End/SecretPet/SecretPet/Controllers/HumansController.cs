using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecretPet.Models;

namespace SecretPet.Controllers
{
    public class HumansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Humans
        public ActionResult Index()
        {
            return View(db.Humen.ToList());
        }

        // GET: Humans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // GET: Humans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Humans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HumanID,Name,LastName,Address")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Humen.Add(human);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(human);
        }

        // GET: Humans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // POST: Humans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HumanID,Name,LastName,Address")] Human human)
        {
            if (ModelState.IsValid)
            {
                db.Entry(human).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(human);
        }

        // GET: Humans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Human human = db.Humen.Find(id);
            if (human == null)
            {
                return HttpNotFound();
            }
            return View(human);
        }

        // POST: Humans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Human human = db.Humen.Find(id);
            db.Humen.Remove(human);
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

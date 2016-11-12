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
    public class SecretPetsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // Sell a pet
        [Authorize]
        public ActionResult SellPet(int? id)
        {
            Pet pet = db.Pets.Find(id);
            pet.State = State.Sold;
            db.Entry(pet).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Adopt a pet
        [Authorize]
        public ActionResult AdoptPet(int? id)
        {
            Pet pet = db.Pets.Find(id);
            pet.State = State.Adopted;
            db.Entry(pet).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: SecretPetsWithoutHome
        [Authorize]
        public ActionResult ListPets()
        {
            return View(db.Pets.ToList().Where(x => x.State == State.FreeForAdoption || x.State == State.FreeForSale));
        }
        // GET: SecretPets
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        // GET: SecretPets/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // GET: SecretPets/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecretPets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "PetID,Name,Breed,DateOfBirth,State,Avatar,Animal,DateOfCreation")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                pet.DateOfCreation = DateTime.Now;
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }

        // GET: SecretPets/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // POST: SecretPets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "PetID,Name,Breed,DateOfBirth,State,Avatar,Animal,DateOfCreation")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        // GET: SecretPets/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // POST: SecretPets/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet pet = db.Pets.Find(id);
            db.Pets.Remove(pet);
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

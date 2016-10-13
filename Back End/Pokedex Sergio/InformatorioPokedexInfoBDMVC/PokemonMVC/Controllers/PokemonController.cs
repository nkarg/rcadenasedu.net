using InformatorioPokedex.Data;
using InformatorioPokedex.Data.PokemonDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonMVC.Controllers
{
    public class PokemonController : Controller
    {
        public DataManager DataM { get; set; }
        // GET: Pokemon
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pokemon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pokemon/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                DataM = new DataManager();
                var pokemon = new Pokemon();
                pokemon.Name = collection["Name"];
                DataM.Add(pokemon);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pokemon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pokemon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pokemon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pokemon/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

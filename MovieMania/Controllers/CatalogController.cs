using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieMania.Data;
using MovieMania.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMania.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CatalogController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult CatalogIndex()
        {
            IEnumerable<Film> objList = _db.Film;
            return View(objList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Film film)
        {
            if(ModelState.IsValid)
            {
                film.FilmId = Guid.NewGuid().ToString();
                _db.Film.Add(film);
                _db.SaveChanges();
                return RedirectToAction("CatalogIndex");
            }
            return View(film);
            
        }

        public IActionResult Delete(string id)
        {
            var film = _db.Film.Find(id);
            ViewBag.Film = film;
            return View(film);
        }
        public IActionResult DeleteFilm(string id)
        {
            var film = _db.Film.Where(el => el.FilmId == id).Single();
            _db.Film.Remove(film);
            _db.SaveChanges();
            return RedirectToAction("CatalogIndex");
        }

    }
}

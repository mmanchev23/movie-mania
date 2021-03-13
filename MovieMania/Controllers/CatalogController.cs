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
            if (id == null || id == "")
            {
                return NotFound();
            }

            var film = _db.Film.Find(id);

            if(film == null)
            {
                return NotFound();
            }

            ViewBag.Film = film;
            return View(film);
        }

        public IActionResult DeleteFilm(string id)
        {
            var film = _db.Film.Where(el => el.FilmId == id).Single();

            if(film == null)
            {
                return NotFound();
            }

            _db.Film.Remove(film);
            _db.SaveChanges();
            return RedirectToAction("CatalogIndex");
        }

        public IActionResult Edit(string id)
        {
            if(id == null || id == "")
            {
                return NotFound();
            }

            var film = _db.Film.Find(id);

            if(film == null)
            {
                return NotFound();
            }    

            ViewBag.Film = film;
            return View(film);
        }

        public IActionResult EditFilm(string id)
        {
            var film = _db.Film.Where(el => el.FilmId == id).Single();

            film.Title = Request.Query["title"];
            film.Description = Request.Query["description"];
            film.Genre = Request.Query["genre"];
            film.Rating = int.Parse(Request.Query["rating"]);
            film.ImageUrl = Request.Query["imageURL"];
            film.TrailerUrl = Request.Query["trailerURL"];

            _db.Film.Update(film);
            _db.SaveChanges();
            return RedirectToAction("CatalogIndex");
            
        }
    }
}

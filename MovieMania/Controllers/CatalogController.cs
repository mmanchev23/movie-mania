using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult CatalogIndex(string sortOrder, string searchString)
        {
            ViewBag.TitleSortOrder = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DescriptionSortOrder = String.IsNullOrEmpty(sortOrder) ? "description_desc" : "";
            ViewBag.GenreSortOrder = String.IsNullOrEmpty(sortOrder) ? "genre_desc" : "";
            ViewBag.RatingSortOrder = String.IsNullOrEmpty(sortOrder) ? "rating_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            var Films = from f in _db.Film select f;

            if(!String.IsNullOrEmpty(searchString))
            {
                Films = Films.Where(f => f.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    Films = Films.OrderByDescending(b => b.Title);
                    break;
                case "description_desc":
                    Films = Films.OrderByDescending(b => b.Description);
                    break;
                case "genre_desc":
                    Films = Films.OrderByDescending(b => b.Genre);
                    break;
                case "rating_desc":
                    Films = Films.OrderByDescending(b => b.Rating);
                    break;
                default:
                    Films = Films.OrderBy(b => b.Title);
                    break;
            }

            return View(Films);
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

                TempData["FilmSuccessMessage"] = "Film was added successfully!";
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

            TempData["FilmDeleteMessage"] = "Film was deleted successfully!";
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Film film)
        {
            if(ModelState.IsValid)
            {
                _db.Film.Update(film);
                _db.SaveChanges();

                TempData["FilmEditMessage"] = "Film was edited successfully!";
                return RedirectToAction("CatalogIndex");
            }

            return View(film);
        }

        public IActionResult Film(string id)
        {
            var film = _db.Film.Where(el => el.FilmId == id).Single();
            ViewBag.Film = film;
            return View(film);
        }

        public IActionResult AddComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _db.Comment.Add(comment);
                _db.SaveChanges();

                TempData["FilmSuccessMessage"] = "Film was added successfully!";
                return RedirectToAction("CatalogIndex");
            }

            return RedirectToAction("Film");
        }

        public IActionResult Comments()
        {
            return View();
        }
    }
}

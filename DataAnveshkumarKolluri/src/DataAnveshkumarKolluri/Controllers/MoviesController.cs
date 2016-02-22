using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using DataAnveshkumarKolluri.Models;

namespace DataAnveshkumarKolluri.Controllers
{
    public class MoviesController : Controller
    {
        private AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Movies
        public IActionResult Index()
        {
            var appDbContext = _context.Movies.Include(m => m.Location);
            return View(appDbContext.ToList());
        }

        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Movie movie = _context.Movies.Single(m => m.MovieID == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "Location");
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "Location", movie.LocationID);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Movie movie = _context.Movies.Single(m => m.MovieID == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "Location", movie.LocationID);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "Location", movie.LocationID);
            return View(movie);
        }

        // GET: Movies/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Movie movie = _context.Movies.Single(m => m.MovieID == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Movie movie = _context.Movies.Single(m => m.MovieID == id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

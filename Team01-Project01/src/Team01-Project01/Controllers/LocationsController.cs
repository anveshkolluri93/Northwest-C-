using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01Project01.Controllers
{
    public class LocationsController : Controller
    {
        private AppDbContext _context;

        public LocationsController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Locations
        public IActionResult Index()
        {
            return View(_context.Location.ToList());
        }

        // GET: Locations/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Location location = _context.Location.Single(m => m.locationId == id);
            if (location == null)
            {
                return HttpNotFound();
            }

            return View(location);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Location.Add(location);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }

        // GET: Locations/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Location location = _context.Location.Single(m => m.locationId == id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Update(location);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }

        // GET: Locations/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Location location = _context.Location.Single(m => m.locationId == id);
            if (location == null)
            {
                return HttpNotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Location location = _context.Location.Single(m => m.locationId == id);
            _context.Location.Remove(location);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
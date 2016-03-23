using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01Project01.Controllers
{
    public class FacultiesController : Controller
    {
        private AppDbContext _context;

        public FacultiesController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Faculties
        public IActionResult Index()
        {
            return View(_context.Faculties.ToList());
        }

        // GET: Faculties/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Faculty faculty = _context.Faculties.Single(m => m.FacultyId == id);
            if (faculty == null)
            {
                return HttpNotFound();
            }

            return View(faculty);
        }

        // GET: Faculties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faculties/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _context.Faculties.Add(faculty);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faculty);
        }

        // GET: Faculties/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Faculty faculty = _context.Faculties.Single(m => m.FacultyId == id);
            if (faculty == null)
            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // POST: Faculties/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _context.Update(faculty);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faculty);
        }

        // GET: Faculties/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Faculty faculty = _context.Faculties.Single(m => m.FacultyId == id);
            if (faculty == null)
            {
                return HttpNotFound();
            }

            return View(faculty);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Faculty faculty = _context.Faculties.Single(m => m.FacultyId == id);
            _context.Faculties.Remove(faculty);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

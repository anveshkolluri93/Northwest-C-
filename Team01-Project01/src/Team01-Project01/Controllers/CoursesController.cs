using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01Project01.Controllers
{
    public class CoursesController : Controller
    {
        private AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Courses
        public IActionResult Index()
        {
            return View(_context.Courses.ToList());
        }

        // GET: Courses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Courses courses = _context.Courses.Single(m => m.CoursesId == id);
            if (courses == null)
            {
                return HttpNotFound();
            }

            return View(courses);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Courses courses)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(courses);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courses);
        }

        // GET: Courses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Courses courses = _context.Courses.Single(m => m.CoursesId == id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

        // POST: Courses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Courses courses)
        {
            if (ModelState.IsValid)
            {
                _context.Update(courses);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courses);
        }

        // GET: Courses/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Courses courses = _context.Courses.Single(m => m.CoursesId == id);
            if (courses == null)
            {
                return HttpNotFound();
            }

            return View(courses);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Courses courses = _context.Courses.Single(m => m.CoursesId == id);
            _context.Courses.Remove(courses);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

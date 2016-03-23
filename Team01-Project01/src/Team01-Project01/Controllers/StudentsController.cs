using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01Project01.Controllers
{
    public class StudentsController : Controller
    {
        private AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Students
        public IActionResult Index()
        {
            var appDbContext = _context.Students.Include(s => s.Courses);
            return View(appDbContext.ToList());
        }

        // GET: Students/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Students students = _context.Students.Single(m => m.StudentsId == id);
            if (students == null)
            {
                return HttpNotFound();
            }

            return View(students);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses");
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Students students)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(students);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", students.CoursesId);
            return View(students);
        }

        // GET: Students/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Students students = _context.Students.Single(m => m.StudentsId == id);
            if (students == null)
            {
                return HttpNotFound();
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", students.CoursesId);
            return View(students);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Students students)
        {
            if (ModelState.IsValid)
            {
                _context.Update(students);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", students.CoursesId);
            return View(students);
        }

        // GET: Students/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Students students = _context.Students.Single(m => m.StudentsId == id);
            if (students == null)
            {
                return HttpNotFound();
            }

            return View(students);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Students students = _context.Students.Single(m => m.StudentsId == id);
            _context.Students.Remove(students);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

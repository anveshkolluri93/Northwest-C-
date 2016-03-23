using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01Project01.Controllers
{
    public class SectionsController : Controller
    {
        private AppDbContext _context;

        public SectionsController(AppDbContext context)
        {
            _context = context;    
        }

        // GET: Sections
        public IActionResult Index()
        {
            var appDbContext = _context.Sections.Include(s => s.Courses).Include(s => s.Faculties);
            return View(appDbContext.ToList());
        }

        // GET: Sections/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.SectionId == id);
            if (section == null)
            {
                return HttpNotFound();
            }

            return View(section);
        }

        // GET: Sections/Create
        public IActionResult Create()
        {
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses");
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "FacultyId", "Faculties");
            return View();
        }

        // POST: Sections/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Sections.Add(section);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", section.CoursesId);
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "FacultyId", "Faculties", section.FacultyId);
            return View(section);
        }

        // GET: Sections/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.SectionId == id);
            if (section == null)
            {
                return HttpNotFound();
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", section.CoursesId);
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "FacultyId", "Faculties", section.FacultyId);
            return View(section);
        }

        // POST: Sections/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Update(section);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CoursesId"] = new SelectList(_context.Courses, "CoursesId", "Courses", section.CoursesId);
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "FacultyId", "Faculties", section.FacultyId);
            return View(section);
        }

        // GET: Sections/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.SectionId == id);
            if (section == null)
            {
                return HttpNotFound();
            }

            return View(section);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Section section = _context.Sections.Single(m => m.SectionId == id);
            _context.Sections.Remove(section);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

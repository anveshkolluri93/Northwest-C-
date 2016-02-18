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
            return View(_context.Section.ToList());
        }

        // GET: Sections/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Section.Single(m => m.sectionId == id);
            if (section == null)
            {
                return HttpNotFound();
            }

            return View(section);
        }

        // GET: Sections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sections/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Section.Add(section);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(section);
        }

        // GET: Sections/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Section.Single(m => m.sectionId == id);
            if (section == null)
            {
                return HttpNotFound();
            }
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

            Section section = _context.Section.Single(m => m.sectionId == id);
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
            Section section = _context.Section.Single(m => m.sectionId == id);
            _context.Section.Remove(section);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

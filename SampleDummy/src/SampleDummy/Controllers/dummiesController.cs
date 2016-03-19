using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using SampleDummy.Models;

namespace SampleDummy.Controllers
{
    public class dummiesController : Controller
    {
        private ApplicationDbContext _context;

        public dummiesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: dummies
        public IActionResult Index()
        {
            return View(_context.dummy.ToList());
        }

        // GET: dummies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            dummy dummy = _context.dummy.Single(m => m.LocationID == id);
            if (dummy == null)
            {
                return HttpNotFound();
            }

            return View(dummy);
        }

        // GET: dummies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: dummies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(dummy dummy)
        {
            if (ModelState.IsValid)
            {
                _context.dummy.Add(dummy);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dummy);
        }

        // GET: dummies/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            dummy dummy = _context.dummy.Single(m => m.LocationID == id);
            if (dummy == null)
            {
                return HttpNotFound();
            }
            return View(dummy);
        }

        // POST: dummies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(dummy dummy)
        {
            if (ModelState.IsValid)
            {
                _context.Update(dummy);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dummy);
        }

        // GET: dummies/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            dummy dummy = _context.dummy.Single(m => m.LocationID == id);
            if (dummy == null)
            {
                return HttpNotFound();
            }

            return View(dummy);
        }

        // POST: dummies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            dummy dummy = _context.dummy.Single(m => m.LocationID == id);
            _context.dummy.Remove(dummy);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

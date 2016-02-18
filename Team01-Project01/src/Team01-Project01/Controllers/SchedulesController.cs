using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;


namespace Team01Project01.Controllers
{
    public class SchedulesController : Controller
    {
        private ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Schedules
        public IActionResult Index()
        {
            return View(_context.Schedule.ToList());
        }

        // GET: Schedules/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Schedule schedule = _context.Schedule.Single(m => m.CRN == id);
            if (schedule == null)
            {
                return HttpNotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Schedule.Add(schedule);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Schedule schedule = _context.Schedule.Single(m => m.CRN == id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Update(schedule);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Schedule schedule = _context.Schedule.Single(m => m.CRN == id);
            if (schedule == null)
            {
                return HttpNotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Schedule schedule = _context.Schedule.Single(m => m.CRN == id);
            _context.Schedule.Remove(schedule);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

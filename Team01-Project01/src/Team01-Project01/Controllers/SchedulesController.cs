using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Team01_Project01.Models;

namespace Team01_Project01.Controllers
{
    public class SchedulesController : Controller
    {
        private AppDbContext _context;

        public SchedulesController(AppDbContext context)
        {
            _context = context;    
        }



        // GET: Schedules
        public IActionResult Index()
        {
            return View(_context.Schedules.ToList());
        }

        // GET: Schedules/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Schedule schedule = _context.Schedules.Single(m => m.ScheduleId == id);
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
                _context.Schedules.Add(schedule);
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

            Schedule schedule = _context.Schedules.Single(m => m.ScheduleId == id);
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

            Schedule schedule = _context.Schedules.Single(m => m.ScheduleId == id);
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
            Schedule schedule = _context.Schedules.Single(m => m.ScheduleId == id);
            _context.Schedules.Remove(schedule);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

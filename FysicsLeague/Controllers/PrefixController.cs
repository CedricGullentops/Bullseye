using FysicsLeague.Data;
using FysicsLeague.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FysicsLeague.Controllers
{
    public class PrefixController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Prefix Prefix { get; set; }

        public PrefixController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(string name)
        {
            Prefix = new Prefix();
            if (name == null)
            {
                //create
                return View(Prefix);
            }
            //Update
            Prefix = _db.Prefixes.FirstOrDefault(p => p.Name.Equals(name));
            if (Prefix == null)
            {
                return NotFound();
            }
            return View(Prefix);
        }

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (_db.Prefixes.FirstOrDefault(p => p.Name == Prefix.Name) == null)
                {
                    _db.Prefixes.Add(Prefix);
                }
                else {
                    _db.Prefixes.Update(Prefix);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Prefix);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert()
        {
            if (ModelState.IsValid)
            {
                _db.Attach(Prefix).State = EntityState.Modified;
                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrefixExists(Prefix.Name))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(Prefix);
        }

        private bool PrefixExists(string id)
        {
            return _db.Prefixes.Any(e => e.Name == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Prefixes.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string name)
        {
            var prefixFromDb = await _db.Prefixes.FirstOrDefaultAsync(p => p.Name == name);
            if (prefixFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Prefixes.Remove(prefixFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}

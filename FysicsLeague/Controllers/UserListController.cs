using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FysicsLeague.Models;
using Microsoft.EntityFrameworkCore;
using FysicsLeague.Data;

namespace FysicsLeague.Controllers
{
    public class UserListController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public User User { get; set; }

        public UserListController(ApplicationDbContext db) {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            User = new User();
            if (id == null) {
                //create
                return View(User);
            }
            //Update
            User = _db.Users.FirstOrDefault(u => u.Id == id);
            if (User == null) {
                return NotFound();
            }
            return View(User);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpsertValid()
        {
           
            if (ModelState.IsValid)
            {
                if (User.Id == 0) {
                    //create
                    _db.Users.Add(User);
                }
                else{
                    _db.Users.Update(User);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(User);
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
            return Json(new { data = await _db.Users.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var userFromDb = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (userFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Users.Remove(userFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}

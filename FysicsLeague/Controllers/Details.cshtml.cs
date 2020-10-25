using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FysicsLeague.Data;
using FysicsLeague.Models;

namespace FysicsLeague.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly FysicsLeague.Data.ApplicationDbContext _context;

        public DetailsModel(FysicsLeague.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Prefix Prefix { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Prefix = await _context.Prefixes.FirstOrDefaultAsync(m => m.Name == id);

            if (Prefix == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

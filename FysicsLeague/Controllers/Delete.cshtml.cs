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
    public class DeleteModel : PageModel
    {
        private readonly FysicsLeague.Data.ApplicationDbContext _context;

        public DeleteModel(FysicsLeague.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Prefix = await _context.Prefixes.FindAsync(id);

            if (Prefix != null)
            {
                _context.Prefixes.Remove(Prefix);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

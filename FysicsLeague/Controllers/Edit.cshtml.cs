using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FysicsLeague.Data;
using FysicsLeague.Models;

namespace FysicsLeague.Controllers
{
    public class EditModel : PageModel
    {
        private readonly FysicsLeague.Data.ApplicationDbContext _context;

        public EditModel(FysicsLeague.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Prefix).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

            return RedirectToPage("./Index");
        }

        private bool PrefixExists(string id)
        {
            return _context.Prefixes.Any(e => e.Name == id);
        }
    }
}

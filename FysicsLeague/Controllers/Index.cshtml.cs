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
    public class IndexModel : PageModel
    {
        private readonly FysicsLeague.Data.ApplicationDbContext _context;

        public IndexModel(FysicsLeague.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Prefix> Prefix { get;set; }

        public async Task OnGetAsync()
        {
            Prefix = await _context.Prefixes.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BullseyeWebPage.Data;
using BullseyeWebPage.Models;

namespace BullseyeWebPage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly BullseyeWebPage.Data.BullseyeWebPageContext _context;

        public IndexModel(BullseyeWebPage.Data.BullseyeWebPageContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BullseyeWebPage.Models;

namespace BullseyeWebPage.Data
{
    public class BullseyeWebPageContext : DbContext
    {
        public BullseyeWebPageContext (DbContextOptions<BullseyeWebPageContext> options)
            : base(options)
        {
        }

        public DbSet<BullseyeWebPage.Models.Movie> Movie { get; set; }
    }
}

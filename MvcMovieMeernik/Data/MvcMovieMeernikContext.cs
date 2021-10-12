using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieMeernik.Models;

namespace MvcMovieMeernik.Data
{
    public class MvcMovieMeernikContext : DbContext
    {
        public MvcMovieMeernikContext (DbContextOptions<MvcMovieMeernikContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieMeernik.Models.Movie> Movie { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using labSPP_3.Models;

namespace labSPP_3.Data
{
    public class PagesComputerContext : DbContext
    {
        public PagesComputerContext (DbContextOptions<PagesComputerContext> options)
            : base(options)
        {
        }

        public DbSet<labSPP_3.Models.Computer> Computer { get; set; } = default!;
    }
}

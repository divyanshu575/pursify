using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pursify.Models;

namespace pursify.Data
{
    public class pursifyContext : DbContext
    {
        public pursifyContext (DbContextOptions<pursifyContext> options)
            : base(options)
        {
        }

        public DbSet<pursify.Models.Purse> Purse { get; set; } = default!;
    }
}

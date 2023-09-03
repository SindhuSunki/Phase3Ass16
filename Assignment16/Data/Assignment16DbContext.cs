using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment16.Models;

namespace Assignment16.Data
{
    public class Assignment16DbContext : DbContext
    {
        public Assignment16DbContext (DbContextOptions<Assignment16DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment16.Models.Task> Task { get; set; } = default!;
    }
}

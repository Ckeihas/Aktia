using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AktiaHaastattelu.Models;

namespace AktiaHaastattelu.Data
{
    public class AktiaHaastatteluContext : DbContext
    {
        public AktiaHaastatteluContext (DbContextOptions<AktiaHaastatteluContext> options)
            : base(options)
        {
        }

        public DbSet<AktiaHaastattelu.Models.Customers> Customers { get; set; }

        public DbSet<AktiaHaastattelu.Models.Customers2Segment> Customers2Segment { get; set; }

        public DbSet<AktiaHaastattelu.Models.Segment> Segment { get; set; }
    }
}

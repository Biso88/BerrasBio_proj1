using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BerrasBio_proj1.DbModel;

namespace BerrasBio_proj1.Data
{
    public class BerrasBio_proj1Context : DbContext
    {
        public BerrasBio_proj1Context (DbContextOptions<BerrasBio_proj1Context> options)
            : base(options)
        {
        }

        public DbSet<BerrasBio_proj1.DbModel.Booking>? Booking { get; set; }

        public DbSet<BerrasBio_proj1.DbModel.Movie>? Movie { get; set; }

        public DbSet<BerrasBio_proj1.DbModel.Salon>? Salon { get; set; }

        public DbSet<BerrasBio_proj1.DbModel.Showing>? Showing { get; set; }
    }
}

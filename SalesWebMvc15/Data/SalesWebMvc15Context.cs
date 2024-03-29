using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc15.Models;

namespace SalesWebMvc15.Data
{
    public class SalesWebMvc15Context : DbContext
    {
        public SalesWebMvc15Context (DbContextOptions<SalesWebMvc15Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

using LinqQueryStudy01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueryStudy01.DBContextm
{
    public class DbcontextM : DbContext
    {
        public DbSet<UserC> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .\\SQLEXPRESS; database = test; uid = sa; password = alencia");
        }

    }
}

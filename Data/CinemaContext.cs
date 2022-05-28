#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cinema.Models;

namespace Cinema.Data
{


    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options)
        // : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server=localhost;database=dotnet_final;uid=root;password=46452020;",
                ServerVersion.AutoDetect(connectionString: @"server=localhost;database=dotnet_final;uid=root;password=46452020;"));
        }

        public DbSet<Cinema.Models.Movie> Movie { get; set; }
    }
}

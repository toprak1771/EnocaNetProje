using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3G5DH7I;database=EnocaWebProjectDB;integrated security=true;");
        }

        public  DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }


    }
}

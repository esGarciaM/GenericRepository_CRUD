using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Entities
{
    internal class Contest:DbContext
    {
        //protected override confi
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Usuario> Usuarios { get;set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder) { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("server=localhost;database=contest;user=sa;password=AFS2018;");
            }
        }

    }
}

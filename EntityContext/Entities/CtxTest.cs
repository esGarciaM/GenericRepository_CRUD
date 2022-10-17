using EntityContext.Interfaces;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Entities
{
    public class CtxTest : DbContext, IContext
    {
        //protected override confi
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbContext Instance => this;


        //public DbContext Instance => this;

        //public DbSet<Usuario> Usuarios { get;set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder) { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("server=localhost;database=context;user=sa;password=AFS2018;");
            }
        }

    }
}

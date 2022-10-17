using EntityContext.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EntityContext.Interfaces
{
    public interface IContext: IDisposable
    {
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        DbContext Instance { get; }
        //DbSet<TEntity> Set<TEntity>() { get;}
    }
}
using EntityContext.Entities;
using EntityContext.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext
{
    public class Crud<T> : ICRUD<T> where T : EntidadBase
    {
        private readonly IContext _context;
        private readonly DbSet<T> _entities;
        public Crud(IContext context) {
            _context = context;
            _entities = _context.Instance.Set<T>();   
        }
        IEnumerable<T> ICRUD<T>.All()
        {
            return _entities.ToList();
        }
        public string test() {
            return "test  OK";
        }
    }
}

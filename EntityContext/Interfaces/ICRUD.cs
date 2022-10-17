using EntityContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Interfaces
{
    public interface ICRUD<T> where T : EntidadBase
    {
        public IEnumerable<T> All();
        public string test();
        //public bool Add(IEntidad entity);
    }
}

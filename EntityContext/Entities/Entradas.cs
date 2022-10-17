using EntityContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityContext.Entities
{
    public class Entradas:EntidadBase
    {
        public string clave { get; set; }
        public string cliente { get; set; }

    }
}

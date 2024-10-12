using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public abstract class Entity //Class base
    {
        /*
         As classes Product e Category tem o mesmo atributo id, usando DDD, permite reunir a logica comum em um só lugar.
         */
        public int id { get; protected set; }
    }
}

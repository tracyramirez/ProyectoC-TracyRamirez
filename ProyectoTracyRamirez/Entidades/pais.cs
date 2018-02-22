using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class pais
    {

      public int id { get; set; }
        public string nombre { get; set; }
        public byte bandera { get; set; }

        public pais(int id, string nombre, byte bandera)
        {
            this.id = id;
            this.nombre = nombre;
            this.bandera = bandera;
        }
    }
}

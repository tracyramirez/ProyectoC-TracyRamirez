using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class persona
    {
        int cedula { get; set; }
        string nombre { get; set; }

        public persona(int cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
        }
    }
}

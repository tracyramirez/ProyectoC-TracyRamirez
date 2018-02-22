using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
      public class aeropuerto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string localidad { get; set; }
        public string iata { get; set; }

        public aeropuerto(int id, string nombre, string localidad, string iata)
        {
            this.id = id;
            this.nombre = nombre;
            this.localidad = localidad;
            this.iata = iata;
        }
    }
}

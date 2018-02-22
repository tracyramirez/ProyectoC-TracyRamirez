using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades 
{
  public  class lugar
    {
        int id { get; set; }
        string nombre { get; set; }

        public lugar(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}

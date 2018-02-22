using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ruta
    {
       public int id { get; set; }
        string paisOrigen { get; set; }
        string paisDestino { get; set; }
        int duración { get; set; }

        public ruta(int id, string paisOrigen, string paisDestino, int duración)
        {
            this.id = id;
            this.paisOrigen = paisOrigen;
            this.paisDestino = paisDestino;
            this.duración = duración;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : persona
    {
       
        public string contrasena { get; set; }
        public int id { get; set; }

        public Usuario()
        {

        }

        public Usuario(string username, string contrasena, int id)
        {
            

            this.contrasena = contrasena;
            this.id = id;
        }
    }
}

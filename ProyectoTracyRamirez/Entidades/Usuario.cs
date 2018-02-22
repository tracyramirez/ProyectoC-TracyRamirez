using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public String username { get; set; }
        public string contrasena { get; set; }
        public String correo { get; set; }
        public Boolean activo { get; set; }
        public Boolean admin { get; set; }
        public int id { get; set; }


       public Usuario()
        {


        }

        public Usuario(string username, string contrasena, string correo, bool activo, bool admin, int id)
        {
            this.username = username;
            this.contrasena = contrasena;
            this.correo = correo;
            this.activo = activo;
            this.admin = admin;
            this.id = id;
        }
    }
}

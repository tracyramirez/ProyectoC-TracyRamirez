using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using ProyectoDAO;
using Npgsql;



namespace ProyectoBO
{
    public class UsuarioBo 
    {

        private UsuarioDao udao;
        public UsuarioBo()
        {
             udao = new UsuarioDao();
            conexion con = new conexion();
        }

        private Boolean validarUsuario(Usuario u)
        {

            if (u == null)
            {

                return false;

            }

            return !u.username.Equals("");
        }
        private Boolean validarContrasena(Usuario u)
        {
            if (u == null)
            {
                return false;

            }
            if (u.contrasena.Length < 6)
            {
                return false;

            }

            return true;
            
        }

    private Boolean verificarContrasena(Usuario u)
        {
            return true;
        }
    
    }
}

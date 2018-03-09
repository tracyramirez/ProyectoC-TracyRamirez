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

        private Boolean Registrar(Usuario u, string registrar)
        {
            try
            {
                if (!validarContrasena(u))
                {
                    //Console.Write("Usuario Registrado");
                    throw new Exception("Usuario Registrado");
                }

                if (!validarContrasena(u))
                {
                    throw new Exception("Contraseña Invalida");


                }

                return udao.insertar(u);
            }
            catch (Exception)
            {

                throw new Exception("Problemas para insertar Usuario");

            }

        }

        public Boolean autentificar(Usuario u)
        {
            if (!validarUsuario(u))
             {
                Console.Write("Usuario Requerido");
             }

            if (!validarContrasena(u))
            {
                Console.Write("Contraseña Invalida");
            }

            return udao.
            }
        }
    }


    


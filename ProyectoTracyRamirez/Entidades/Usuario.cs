using ProyectoDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Entidades
{
    public class Usuario 
    {
        static NpgsqlConnection conexion;
        Conexion con = new Conexion();


        public static void conexiones()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            int clave = 1234;
            string baseDatos = "gestionVuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public string contrasena { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public int cedula { get; set; }
        public string usuario { get; set; }

        public Usuario(string contrasena, int id, string nombre, int cedula, string usuario)
        {
            this.contrasena = contrasena;
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
            this.usuario = usuario;
        }

        public Usuario()
        {

        }

        public void verificarContrasena(string contrasena, int id, string nombre, int cedula, string usuario)
        {
            this.contrasena = contrasena;
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
            this.usuario = usuario;
            con.InsertarUsuario(cedula, nombre, contrasena, usuario);

        }

        public Boolean validarContra(string usuario,string contrasena)
        {
            con.ValidarContrasena(usuario, contrasena);
           

            return false;
         }
            
        }


    }



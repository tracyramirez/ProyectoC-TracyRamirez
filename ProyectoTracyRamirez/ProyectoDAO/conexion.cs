using System;
using Npgsql;

namespace ProyectoDAO
{
    public class Conexion
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void conexiones()
        {
            string servidor = "localhost";
            int puerto = 5432;

            string usuario = "postgres";
            int clave = 1234
                ;
            string baseDatos = "gestionVuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public void AgregarPais(int id, string nombre)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO pais (id,nombre) VALUES ('" + id + "','" + nombre + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarPais( string nombre)
        {
            conexiones();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE pais SET  nombre = '" + nombre +  "' WHERE nombre = '" + nombre + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void AgregarLugar(int id_lugar, string nombre)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO lugar (id_lugar,nombre) VALUES ('" + id_lugar + "','" + nombre + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void AgregarAeroli(int id_aerolinea, string nombre)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aerolinea (id_aerolinea,nombre) VALUES ('" + id_aerolinea + "','" + nombre + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void AgregarAeropuerto(int id_aero,string nombre,string localidad,string iata)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO aeropuerto (id_aero,nombre,localidad,iata) VALUES ('" + id_aero + "','" + nombre+ "','" + localidad + "','" + iata + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void AgregarVehiculo(int id, string marca, string modelo, string tipo, int precio, int cantidad)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO vehiculo (id,marca,modelo,tipo,precio,cantidad) VALUES ('" + id + "','" + marca + "','" + modelo + "','" +tipo + "','" + precio + "','" + cantidad + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void AgregarHotel(int id, int precio)
        {
            conexiones();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO hotel(id,precio) VALUES ('" + id + "','" + precio + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void InsertarUsuario(int cedula, string nombre, string contrasena, string tipo)
        {
            try { 
                conexion.Open();
                cmd = new NpgsqlCommand("INSERT INTO usuario (cedula, nombre, contrasena , tipo) VALUES ('" + cedula + "', '" + nombre + "', '" + contrasena + "', '" + tipo + "')", conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {

                Console.WriteLine(error);

            }

        }

        public String TipoDeUsuario(String cedula)
        {
            String tipoUsuario = String.Empty;

            conexiones();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT cedula,tipo FROM usuario WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    tipoUsuario = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();


            return tipoUsuario;
        }

        public String ValidarContraseña(String cedula)
        {

            String contraseña = String.Empty;

            conexiones();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT cedula,contraseña FROM usuarios WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    contraseña = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();


            return Security.DesEncriptarContraseña(contraseña);
        }


        public Boolean ValidarContrasena(string usuario, string contrasena)
        {
            string nombre;
            conexiones();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM usuario WHERE usuario='" + usuario + "' and contrasena = '" + contrasena + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                {
                    nombre = dr.GetString(1);
                }
            conexion.Close();


            return false;
        }




        public String ConsultarInformacion(String cedula)
        {

            String informacionUsuario = String.Empty;

            conexiones();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM usuario WHERE cedula='" + cedula + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {   
                    informacionUsuario = lectorConsulta.GetString(1);
                }
            }
            conexion.Close();

            return informacionUsuario;
        }


        public int ConsultarCedula(String nombre)
        {
            int cedulaU = 0;
            conexiones();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM usuarios WHERE nombre='" + nombre + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    //cedula, nombre y tipo de usuario
                    //informacionUsuario = lectorConsulta.GetString(0) + ";" + lectorConsulta.GetString(1)  + ";"+ lectorConsulta.GetString(3);
                    cedulaU = int.Parse(lectorConsulta.GetString(0));

                }
            }
            conexion.Close();


            return cedulaU;

        }

        }
    }



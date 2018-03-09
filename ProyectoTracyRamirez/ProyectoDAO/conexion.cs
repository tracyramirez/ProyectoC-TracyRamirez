using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Entidades;
using ProyectoDAO;
using System.Windows.Forms;
using System.Data;

namespace Entidades
{
    public class aeropuerto
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


        public int id_aero { get; set; }
        public string nombre { get; set; }
        public string localidad { get; set; }
        public string iata { get; set; }


        public aeropuerto()
        {

        }
        public void aeropuertoNego(int id_aero, string nombre, string localidad, string iata)
        {
            this.id_aero = id_aero;
            this.nombre = nombre;
            this.localidad = localidad;
            this.iata = iata;
            con.AgregarAeropuerto(id_aero, nombre, localidad, iata);


        }
        public void tbAeropuerto(DataGridView AgregarAeropuerto)
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id_aero,nombre,localidad,iata FROM aeropuerto", conexion);
                adapter.Fill(dataSe, "aeropuerto");
                AgregarAeropuerto.DataSource = dataSe.Tables[0];
                AgregarAeropuerto.Columns[0].HeaderCell.Value = "Identificador";
                AgregarAeropuerto.Columns[1].HeaderCell.Value = "Nombre";
                AgregarAeropuerto.Columns[2].HeaderCell.Value = "localidad";
                AgregarAeropuerto.Columns[3].HeaderCell.Value = "Iata";

                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es " + e);

            }
        }
    } }
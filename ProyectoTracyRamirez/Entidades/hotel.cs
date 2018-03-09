using ProyectoDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Entidades
{
    public class hotel
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
        public int id { get; set; }
        public int precio { get; set; }

        public hotel()
        {

        }
        public void hotelNe(int id, int precio)
        {
            this.id = id;
            this.precio = precio;
            con.AgregarHotel(id, precio);
        }

        public void tbHotel(DataGridView AgregarHotel)
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id,precio FROM hotel", conexion);
                adapter.Fill(dataSe, "hotel");
                AgregarHotel.DataSource = dataSe.Tables[0];
                AgregarHotel.Columns[0].HeaderCell.Value = "Identificador";
                AgregarHotel.Columns[1].HeaderCell.Value = "precio";
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es " + e);
            }
        }
    }
}


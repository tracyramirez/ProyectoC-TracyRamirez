using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Npgsql;
using ProyectoDAO;

namespace Entidades

{
    public class aerolinea

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
        public int id_aerolinea { get; set; }
        public string nombre { get; set; }

        public aerolinea()
        {

        }

        public void aerolineaNego(int id_aerolinea, string nombre)
        {
            this.id_aerolinea = id_aerolinea;
            this.nombre = nombre;
            con.AgregarAeroli(id_aerolinea, nombre);

        }

        public void tbAerolinea(DataGridView AgregaAeroli)
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id_aerolinea,nombre FROM aerolinea", conexion);
                adapter.Fill(dataSe, "aerolinea");
                AgregaAeroli.DataSource = dataSe.Tables[0];
                AgregaAeroli.Columns[0].HeaderCell.Value = "Identificador";
                AgregaAeroli.Columns[1].HeaderCell.Value = "Nombre";
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es " + e);
            }
        }
    }
}


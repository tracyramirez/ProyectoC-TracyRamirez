using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDAO;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Entidades
{

    public class pais
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
        public string nombre { get; set; }
        public pais()
        {

        }
        public void paisS (int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            con.AgregarPais(id, nombre);
        }
       
        public void tbPais(DataGridView AgregarPais )
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT nombre , id FROM pais",conexion);
                adapter.Fill(dataSe,"pais");
                AgregarPais.DataSource = dataSe.Tables[0];
                AgregarPais.Columns[0].HeaderCell.Value = "nombre";
                AgregarPais.Columns[1].HeaderCell.Value = "id";
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es "+e);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ProyectoDAO;
using Entidades;

namespace Entidades 
{
  public  class lugar 
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
        public int id_lugar { get; set; }
        public string nombre { get; set; }

        public lugar()
        {

        }
        public void lugarNe(int id_lugar, string nombre)
        {
            this.id_lugar = id_lugar;
            this.nombre = nombre;
            con.AgregarLugar(id_lugar,nombre);
        }

        public void tbLugar(DataGridView Agregarlugar)
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id_lugar,nombre FROM lugar ORDER BY nombre", conexion);
                adapter.Fill(dataSe, "lugar");
                Agregarlugar.DataSource = dataSe.Tables[0];
                Agregarlugar.Columns[0].HeaderCell.Value = "Identificador";
                Agregarlugar.Columns[1].HeaderCell.Value = "nombre";
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es " + e);
            }
        } }
}

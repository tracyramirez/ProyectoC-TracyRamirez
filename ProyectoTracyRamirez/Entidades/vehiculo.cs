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
    public class vehiculo
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

        int id { get; set; }
       string marca { get;set;}
       string modelo{get;set;}
       string tipo{get;set;}
        int precio { get; set;}
       int cantidad {get;set; }

        public void vehiculoNego(int id, string marca, string modelo, string tipo,int precio,int cantidad)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.precio = precio;
            this.cantidad = cantidad;

            con.AgregarVehiculo(id, marca, modelo, tipo, precio, cantidad);


        }
        public void tbVehiculo(DataGridView AgregarVehiculo)
        {
            try
            {
                conexiones();
                conexion.Open();
                DataSet dataSe = new DataSet();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id,marca,modelo,tipo,precio,cantidad FROM vehiculo", conexion);
                adapter.Fill(dataSe, "vehiculo");
                AgregarVehiculo.DataSource = dataSe.Tables[0];
                AgregarVehiculo.Columns[0].HeaderCell.Value = "Identificador";
                AgregarVehiculo.Columns[1].HeaderCell.Value = "Marca";
                AgregarVehiculo.Columns[2].HeaderCell.Value = "Modelo";
                AgregarVehiculo.Columns[3].HeaderCell.Value = "Tipo";
                AgregarVehiculo.Columns[4].HeaderCell.Value = "Precio";
                AgregarVehiculo.Columns[5].HeaderCell.Value = "Cantidad";

                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error es " + e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDAO;
using Entidades;
using Npgsql;
namespace ProyectoTracyRamirez
{
    public partial class Vehiculo : Form
    {
        public Vehiculo()
        {
            InitializeComponent();
        }

               vehiculo ve = new vehiculo();
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtmodelo.Text;
            string tipo = txtTipo.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            MessageBox.Show("Se ha insertado el registro correctamente.");
            vehiculo ve = new vehiculo();
            ve.vehiculoNego(id,marca,modelo,tipo,precio,cantidad);
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {

            ve.tbVehiculo(dataVehiculo);
           

        }
    }
}

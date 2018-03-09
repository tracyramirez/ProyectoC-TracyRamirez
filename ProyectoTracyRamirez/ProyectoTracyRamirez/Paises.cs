using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Npgsql;

namespace ProyectoTracyRamirez
{
    public partial class Paises : Form
    {
        // Conexion conectar = new Conexion();

        pais pais = new pais();

        public Paises()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

       
        private void Paises_Load(object sender, EventArgs e)
        {
            pais.tbPais(dataPais);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;

            MessageBox.Show("Se ha insertado el registro correctamente.");
            
            pais.paisS(id, nombre);
           


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}

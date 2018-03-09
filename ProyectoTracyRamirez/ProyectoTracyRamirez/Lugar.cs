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
    public partial class Lugar : Form
    {

        lugar lu = new lugar();
        public Lugar()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id_lugar = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            MessageBox.Show("Se ha insertado el registro correctamente.");
            lugar lu = new lugar();
            lu.lugarNe(id_lugar, nombre);

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            lu.tbLugar(dataLugar);
          
        }
    }
}

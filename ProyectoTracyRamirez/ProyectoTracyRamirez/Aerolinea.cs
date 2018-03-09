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
    public partial class Aerolinea : Form
    {
        aerolinea aer = new aerolinea();
        public Aerolinea()
        {
            InitializeComponent();
        }

        private void Aerolinea_Load(object sender, EventArgs e)
        {
            aer.tbAerolinea(dataAero);
        }

        private void btnRegistrarAer_Click(object sender, EventArgs e)
        {
            int id_aerolinea = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            MessageBox.Show("Se ha insertado el registro correctamente.");
            aerolinea aer = new aerolinea();
            aer.aerolineaNego(id_aerolinea,nombre);
            //aer.tbAerolinea(AgregaAeroli);
           
           
        }
    }
}

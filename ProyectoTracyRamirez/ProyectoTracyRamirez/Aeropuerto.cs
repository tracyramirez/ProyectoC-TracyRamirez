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
    public partial class Aeropuerto : Form
    {

        aeropuerto aer = new aeropuerto();
        public Aeropuerto()
        {
            InitializeComponent();
        }

        private void btnAcertarAerop_Click(object sender, EventArgs e)
        {
            int id_aero = Convert.ToInt32(txtid.Text);
            string nombre = txtnombre.Text;
            string localidad = txtlocalidad.Text;
            string iata = txtiata.Text;
            MessageBox.Show("Se ha insertado el registro correctamente.");
            aeropuerto aer = new aeropuerto();
            aer.aeropuertoNego(id_aero, nombre, localidad, iata);
        }

        private void dataAeropuerto_Load(object sender, EventArgs e)
        {
            aer.tbAeropuerto(dataAerop);
        }
    }
}

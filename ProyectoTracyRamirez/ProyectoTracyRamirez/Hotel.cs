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

namespace ProyectoTracyRamirez
{
    public partial class Hotel : Form
    {
        hotel hotel = new hotel();
        public Hotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdentificador.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            MessageBox.Show("Se ha insertado el registro correctamente.");
            hotel hotel = new hotel();
            hotel.hotelNe(id, precio);
            
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            hotel.tbHotel(dataHotel);

        }
    }
}

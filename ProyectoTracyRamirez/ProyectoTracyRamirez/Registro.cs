using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Entidades;
using ProyectoDAO;


namespace ProyectoTracyRamirez
{
    public partial class Registro : Form
    {

        Conexion con = new Conexion();
             
        public Registro()
        {
            InitializeComponent();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {


                MessageBox.Show("Debe de llenar todos los campos.");
            }
            else
            {

                int cedula = int.Parse(textBox1.Text);
                string nombre = textBox2.Text;
                string contraseña = textBox3.Text;


                con.InsertarUsuario(cedula, nombre, Security.EncriptarContraseña(contraseña), "Cliente");
                MessageBox.Show("Usuario registrado");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }
    }
}

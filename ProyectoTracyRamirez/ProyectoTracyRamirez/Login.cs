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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        // Validaciones validaciones = new Validaciones();

        Conexion con = new Conexion();

        public static string nombreUsuario = String.Empty;

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Debe de llenar todos los datos.");
            }
            else
            {

                String usuario = con.TipoDeUsuario(textBox1.Text);
                String contraseña = con.ValidarContraseña(textBox2.Text);

                if (usuario.Equals("Administrador") && contraseña.Equals(textBox1.Text))
                {
                    this.Hide();
                  ///  Menu_Principal_Administrador v = new Menu_Principal_Administrador();
                   // v.Show();
                    nombreUsuario = con.ConsultarInformacion(textBox1.Text);
                    Console.WriteLine(con.ConsultarInformacion(textBox2.Text));
                }
                else if (usuario.Equals("Cliente") && contraseña.Equals(textBox1.Text))
                {

                    this.Hide();
                  ///  Menu_Principal_Usuarios v = new Menu_Principal_Usuarios();
                    //v.Show();
                    nombreUsuario = con.ConsultarInformacion(textBox1.Text);
                    Console.WriteLine(con.ConsultarInformacion(textBox1.Text));

                }
                else
                {
                    MessageBox.Show("Usuario No Registrado en el Sistema");
                }
            }


        }

    //Conexion c = new Conexion();
    //string usuario = textBox1.Text;
    //string contrasena = textBox2.Text;
    //c.ValidarContrasena(usuario, contrasena);


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

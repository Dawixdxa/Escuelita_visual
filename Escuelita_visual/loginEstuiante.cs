using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuelita_visual
{
    public partial class loginEstuiante : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3SLF09A;Initial Catalog=EscuelaVisual;Integrated Security=True");

        public loginEstuiante()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            con.Open();

          string consulta1 = "SELECT * FROM estudiantes WHERE usuario='" + txtUsuario.Text + "'and contraseña='" + txtPass.Text + "'";



            SqlCommand comando = new SqlCommand(consulta1, con);
            SqlDataReader lector;
            lector = comando.ExecuteReader();





            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");

                this.Hide();
                new Estudiantes().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al iniciar sesion");

                this.Hide();
                new loginEstuiante().ShowDialog();
                this.Close();

            }



            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }
    }
}

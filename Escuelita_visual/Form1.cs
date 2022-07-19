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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3SLF09A;Initial Catalog=EscuelaVisual;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string consulta1 = "SELECT * FROM usuario WHERE usuario='"+txtUsuario.Text+"'and contraseña='"+txtPass.Text+"'and Cargo='P'";
            //string consulta2 = "SELECT * FROM usuario WHERE usuario='" + txtUsuario.Text + "'and contraseña='" + txtPass.Text + "'and Cargo='E'";



            SqlCommand comando = new SqlCommand(consulta1, con);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

           



            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");

                this.Hide();
                new Profesores().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al iniciar sesion ");

                this.Hide();
                new Form1().ShowDialog();
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

        //public void login(string usuario, string contraseña)
        //{

        //    con.Open();
        //    string consulta = "SELECT * FROM usuario WHERE usuario='" + txtUsuario.Text + "' and contraseña='" + txtPass.Text + "' and Cargo = P '";

        //    consulta.Parameters.AddWithValue("usuario", usuario);


        //}
    }
}

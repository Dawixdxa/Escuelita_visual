using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuelita_visual
{
    public partial class Profesores : Form
    {
        Notas notas;
        Asistenciacs asis;
        public Profesores()
        {
            InitializeComponent();
            notas = new Notas();
            asis = new Asistenciacs();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {

            notas.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            asis.ShowDialog();
        }
    }
}

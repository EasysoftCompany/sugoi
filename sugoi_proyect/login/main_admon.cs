using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class main_admon : Form
    {
        int id_empleado;
        public main_admon(int id_empleado)
        {
            this.id_empleado = id_empleado;
            InitializeComponent();
            nom_admon.Text = "Clave Unica de Empleado: " + id_empleado;
        }

        private void main_admon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alta alt = new Alta(id_empleado);
            this.Hide();
            alt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en Construccion!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en Construccion!");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Funcion en Construccion!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en Construccion!");
        }
    }
}

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
    public partial class main_empleado : Form
    {
        int id_emp = 0;
        public main_empleado(int id_empleado)
        {
            id_emp = id_empleado;
            InitializeComponent();
            nombre_emp.Text = "Clave Unica de Empleado: " + id_emp;
        }

         private void main_empleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en construccion! Gracias por su espera");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

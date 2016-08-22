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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.usr.Text == "Gera" && this.pwd.Text == "12345")
            {
                main_empleado emp = new main_empleado();

                emp.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Combinacion de Usuario y Contraseña Incorrectos, intente de nuevo");
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario del sistema SUGOI");
        }
    }
}

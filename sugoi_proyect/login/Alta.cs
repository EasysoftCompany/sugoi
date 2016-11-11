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
    public partial class Alta : Form
    {
        int id_usr;
        public Alta(int id_usr)
        {
            this.id_usr = id_usr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_admon admon = new main_admon(id_usr);
            this.Hide();
            admon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alta_empleado alta_emp = new alta_empleado(id_usr);
            this.Hide();
            alta_emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion En construccion!!!");
        }
    }
}

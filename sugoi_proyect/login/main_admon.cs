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
 
        public main_admon()
        {
  
            InitializeComponent();
            
        }

        private void main_admon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alta alt = new Alta();
            this.Hide();
            alt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bajas baja = new bajas();
            this.Hide();
            baja.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion en Construccion!");
        }
    }
}

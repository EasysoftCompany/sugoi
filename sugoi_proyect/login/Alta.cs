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
    
        public Alta()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_admon admon = new main_admon();
            this.Hide();
            admon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alta_empleado alta_emp = new alta_empleado();
            this.Hide();
            alta_emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alta_admon alta_admin = new alta_admon();
            this.Hide();
            alta_admin.Show();
        }
    }
}

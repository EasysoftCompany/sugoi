using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class alta_empleado : Form
    {
        int id_emp;
        public alta_empleado(int id_emp)
        {
            this.id_emp = id_emp;
            InitializeComponent();
        }

        private void alta_empleado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            String usr = usuario.Text;
            String pass = contraseña.Text;
            String name = nombre.Text;
            String app = ap.Text;
            String amm = am.Text;
            String phone = tel.Text;
            String dire = dir.Text;
            String email = mail.Text;
            String horas = horas_trabajo.Value.ToString();
            String tur = turno.Text;
            

            MySqlCommand sql = null;
            sql = new MySqlCommand();

            //Indicamos el Query a ejecutar por el commando;
            sql.CommandText = "call sp_alta_emp('" + usr + "','" + pass + "','" + name + "','" + app + "','" + amm + "','" + phone + "','" + dire + "','" + email + "','" + horas + "','" + tur + "');";
            sql.Connection = Bd.ObtenerConexion();



            MySqlDataReader consulta;


            //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
            consulta = sql.ExecuteReader();

            while(consulta.Read())
            {
                
                MessageBox.Show(consulta.GetString(0));
            }

            Alta al = new Alta(id_emp);
            this.Hide();
            al.Show();
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            Alta al = new Alta(id_emp);
            this.Hide();
            al.Show();
        }
    }
}

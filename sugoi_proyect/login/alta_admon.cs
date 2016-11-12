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
    public partial class alta_admon : Form
    {
   
        public alta_admon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta al = new Alta();
            this.Hide();
            al.Show();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            string usr = usuario.Text;
            string pass = contraseña.Text;
            string name = nombre.Text;
            string app = ap.Text;
            string amm = am.Text;
            string phone = tel.Text;
            string dire = dir.Text;
            string email = mail.Text;
            string horas = horas_trabajo.Value.ToString();
            string tur = cbo_tur.SelectedItem.ToString();


            if (!usr.Equals("") && !pass.Equals(""))
            {

                MySqlCommand sql = null;
                sql = new MySqlCommand();
                try
                {
                    //Indicamos el Query a ejecutar por el commando;
                    sql.CommandText = "call sp_alta_admon('" + usr + "','" + pass + "','" + name + "','" + app + "','" + amm + "','" + phone + "','" + dire + "','" + email + "','" + horas + "','" + tur + "');";
                sql.Connection = Bd.ObtenerConexion();



                MySqlDataReader consulta;


                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader

               
                 consulta = sql.ExecuteReader();
                while (consulta.Read())
                {

                    MessageBox.Show(consulta.GetString(0));

                }
                                Alta al = new Alta();
                this.Hide();
                al.Show();
                }catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("El usuario y la contraseña deben tener algun valor!");
            }
        }
    }
}

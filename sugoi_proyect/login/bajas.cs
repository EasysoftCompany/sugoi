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
    public partial class bajas : Form
    {
        public bajas()
        {
            InitializeComponent();
            MySqlCommand sql = null;
            sql = new MySqlCommand();

            //Indicamos el Query a ejecutar por el commando;
            sql.CommandText = "call sp_get_all_users();";
            sql.Connection = Bd.ObtenerConexion();


            MySqlDataReader consulta;

            //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
            consulta = sql.ExecuteReader();

            while (consulta.Read())
            {
                cbo_usuario.Items.Add(consulta.GetString(0));
            }
        }

        private void cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand sql = null;
            sql = new MySqlCommand();

            //Indicamos el Query a ejecutar por el commando;
            sql.CommandText = "call sp_get_user_name('" + cbo_usuario.SelectedItem.ToString()+"');";
            sql.Connection = Bd.ObtenerConexion();


            MySqlDataReader consulta;

            //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
            consulta = sql.ExecuteReader();

            while (consulta.Read())
            {
                label2.Text = consulta.GetString(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand sql = null;
            sql = new MySqlCommand();
            try
            {
                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "call sp_delete_user('" + cbo_usuario.SelectedItem.ToString() + "');";
                sql.Connection = Bd.ObtenerConexion();


                MySqlDataReader consulta;

                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                consulta = sql.ExecuteReader();

                while (consulta.Read())
                {
                    MessageBox.Show(consulta.GetString(0));
                }
                main_admon admon = new main_admon();
                this.Hide();
                admon.Show();
            }
            catch(Exception ex) { MessageBox.Show("ERROR: " + ex.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_admon admon = new main_admon();
            this.Hide();
            admon.Show();
        }
    }
}

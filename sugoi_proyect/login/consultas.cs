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
    public partial class consultas : Form
    {
        public consultas()
        {
            InitializeComponent();

            try
            {
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
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = null;
                sql = new MySqlCommand();

                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "sp_get_all_data_user('" + cbo_usuario.SelectedItem.ToString() + "');";
                sql.Connection = Bd.ObtenerConexion();


                MySqlDataReader consulta;

                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                consulta = sql.ExecuteReader();

                while (consulta.Read())
                {
                    nom.Text = consulta.GetString(0);
                    tel.Text = consulta.GetString(1);
                    dir.Text = consulta.GetString(2);
                    mail.Text = consulta.GetString(3);
                    hrs.Text = consulta.GetString(4);
                    turno.Text = consulta.GetString(5);
                    antiguedad.Text = consulta.GetString(6);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_admon admon = new main_admon();
            this.Hide();
            admon.Show();
        }
    }
}

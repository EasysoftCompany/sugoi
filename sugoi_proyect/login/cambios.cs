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
    public partial class cambios : Form
    {
        public cambios()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = null;
                sql = new MySqlCommand();

                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "sp_get_all_data_user_modificacion('" + cbo_usuario.SelectedItem.ToString() + "');";
                sql.Connection = Bd.ObtenerConexion();


                MySqlDataReader consulta;

                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                consulta = sql.ExecuteReader();

                while (consulta.Read())
                {
                    nom.Text = consulta.GetString(0);
                    ap.Text = consulta.GetString(1);
                    am.Text = consulta.GetString(2);
                    tel.Text = consulta.GetString(3);
                    dir.Text = consulta.GetString(4);
                    mail.Text = consulta.GetString(5);
                    hrs.Text = consulta.GetString(6);
                    turno.Text = consulta.GetString(7);
                    antiguedad.Text = consulta.GetString(8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            string name = nom.Text;
            string app = ap.Text;
            string amm = am.Text;
            string phone = tel.Text;
            string dire = dir.Text;
            string email = mail.Text;
            string horas = hrs.Value.ToString();
            string tur = turno.Text ;
            int ant = Int32.Parse(antiguedad.Text);


            
                MySqlCommand sql = null;
                sql = new MySqlCommand();
                try
                {
                    //Indicamos el Query a ejecutar por el commando;
                    sql.CommandText = "call sp_modify_user('" + cbo_usuario.SelectedItem.ToString() + "','" + name + "','" + app + "','" + amm + "','" + phone + "','" + dire + "','" + email + "','" + horas + "','" + tur + "','" + ant + "');";
                    sql.Connection = Bd.ObtenerConexion();



                    MySqlDataReader consulta;


                    //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                    consulta = sql.ExecuteReader();

                    while (consulta.Read())
                    {

                        MessageBox.Show(consulta.GetString(0));
                    }

                    main_admon al = new main_admon();
                    this.Hide();
                    al.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
            }
    }
}

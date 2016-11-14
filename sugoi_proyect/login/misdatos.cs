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
    public partial class misdatos : Form
    {
        int id_emp;
        public misdatos(int id_emp)
        {
            this.id_emp = id_emp;
            InitializeComponent();

            try
            {
                MySqlCommand sql = null;
                sql = new MySqlCommand();

                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "sp_mis_datos('" + id_emp+ "');";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_empleado emp = new main_empleado(id_emp);
            this.Hide();
            emp.Show();
        }
    }
}

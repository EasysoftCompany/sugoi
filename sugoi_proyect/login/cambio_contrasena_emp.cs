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
    public partial class cambio_contrasena_emp : Form
    {
        int id_emp;
        public cambio_contrasena_emp(int id_emp)
        {
            this.id_emp = id_emp;
             InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string act = actual.Text;
            string nuev = nueva.Text;
            string conf = confirmacion.Text;


            if(nuev.Equals(conf))
            {
                try
                {
                    MySqlCommand sql = null;
                    sql = new MySqlCommand();

                    //Indicamos el Query a ejecutar por el commando;
                    sql.CommandText = "call sp_change_pwd('"+id_emp+ "','" + act + "','" + nuev + "');";
                    sql.Connection = Bd.ObtenerConexion();


                    MySqlDataReader consulta;

                    //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                    consulta = sql.ExecuteReader();

                    while (consulta.Read())
                    {
                        MessageBox.Show(consulta.GetString(0));
                    }
                    main_empleado emp = new main_empleado(id_emp);
                    this.Hide();
                    emp.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
                

            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, porfavor verifique la informacion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_empleado emp = new main_empleado(id_emp);
            this.Hide();
            emp.Show();
        }
    }
}

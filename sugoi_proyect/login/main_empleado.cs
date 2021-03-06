﻿using System;
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
    public partial class main_empleado : Form
    {
        int id_emp;
        public main_empleado(int id_emp)
        {
            this.id_emp = id_emp;
            InitializeComponent();

            datos.Text = "Bienvenido(a) de nuevo ";
            try
            {
                MySqlCommand sql = null;
                sql = new MySqlCommand();

                //Indicamos el Query a ejecutar por el commando;
                sql.CommandText = "sp_get_user_full_name('" + id_emp+ "');";
                sql.Connection = Bd.ObtenerConexion();


                MySqlDataReader consulta;

                //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
                consulta = sql.ExecuteReader();

                while (consulta.Read())
                {
                    datos.Text += consulta.GetString(0);
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }


    

         private void main_empleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambio_contrasena_emp contra = new cambio_contrasena_emp(id_emp);
            this.Hide();
            contra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            misdatos misdatos = new misdatos(id_emp);
            this.Hide();
            misdatos.Show();
        }
    }
}

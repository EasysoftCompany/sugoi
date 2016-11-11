using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace login
{
    public partial class login : Form
    {
       
       

        public login()
        {
            
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                

            String uss = this.usr.Text; //Valor ingresado por el usuario en el recuadro marcado como "Usuario"
            String Pass = this.pwd.Text;

            //Definimos una variable de tipo MySqlCommand Que nos servira para ejecutar Querys a la BD;
                    
            MySqlCommand sql = null;
            sql = new MySqlCommand();

            //Indicamos el Query a ejecutar por el commando;
            sql.CommandText = "call sp_login('"+uss+"','"+Pass+"');";
            sql.Connection = Bd.ObtenerConexion();


            MySqlDataReader consulta;

            //Como nos interesa recuperar un valor concreto de la base de datos ejecutamos un DataReader
            consulta = sql.ExecuteReader();

            int id_usr = 0;
            int access;
                while (consulta.Read()){

                     id_usr = consulta.GetInt32(0);
                     access = consulta.GetInt32(1);

                    if(access == 1){

                        main_admon admon = new main_admon(id_usr);
                        MessageBox.Show("Conectado con Exito como Administrador!");
                        admon.Show();
                        this.Hide();
                    }

                    else{

                        main_empleado emp = new main_empleado(id_usr);
                        MessageBox.Show("Conectado con Exito como Empleado !");
                        emp.Show();
                        this.Hide();
                    }

                }
         
            
                if(id_usr == 0) { MessageBox.Show("Combinacion de Usuario y Contraseña Incorrectos, intente de nuevo"); }    
                
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario del sistema SUGOI");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

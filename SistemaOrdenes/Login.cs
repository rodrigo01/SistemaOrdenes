using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaOrdenes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Usuario esta en blanco");
            }
            else
            {

                OleDbCommand comand = new OleDbCommand();
                OleDbDataReader lectura; //lecto de datos
                Conexion conectar = new Conexion();
                comand.Connection = conectar.con; //conectamos
                conectar.con.Open();

                //sql de busqueda y realizamos consulta
                String _user = tbUser.Text;
                String _pass = tbPassword.Text;

                String consulta = "SELECT * FROM Usuarios Where user = \"" + _user + "\" and password = \"" + _pass + "\"";
                comand.CommandText = consulta;
                lectura = comand.ExecuteReader();

                String usuario = "";

                while (lectura.Read())
                {
                    usuario = lectura["user"].ToString();
                }
                conectar.con.Close();
                if (usuario.Equals(""))
                {
                    System.Windows.Forms.MessageBox.Show("Informacion de acceso erronea");
                }
                else
                {

                    Menumain mmain = new Menumain();

                    mmain.Show();
                    
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmNuevoProveedor : Form
    {
        public frmNuevoProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\irtec\BD_Sistema.mdb");
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into Proveedores (nombre, direccion,rfc,telefono,contacto,correo,extension) VALUES('" + tbNombre.Text + "','" + tbDireccion.Text + "','" + tbRFC.Text + "','" + tbTelefono.Text + "','" + tbContacto.Text + "','" + tbCorreo.Text + "','" + tbExtension.Text + "')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Proveedor Agregado");
            con.Close();
            this.Close();
            
        }

        private void frmNuevoProveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSource.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.dbSource.Proveedores);

        }

        private void bidSourceProveedor_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

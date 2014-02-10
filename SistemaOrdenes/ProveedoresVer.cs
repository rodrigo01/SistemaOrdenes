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
    public partial class ProveedoresVer : Form
    {
        int idedit;
        public ProveedoresVer()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            frmNuevoProveedor frmNvoProv = new frmNuevoProveedor();
            frmNvoProv.Show();
        }

        private void ProveedoresVer_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();


            dgProveedores.DataSource = proveedores.getProveedoresDG(conectar.con);
            dgProveedores.Columns["ID"].Width = 30;
            dgProveedores.Columns["Nombre"].Width = 250;
            /*proveedores.getProveedor(3, conectar.con);
            textBox2.Text = proveedores.nombre;*/      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();

            dgProveedores.DataSource = proveedores.getProveedoresByNameDG(textBox1.Text,conectar.con);

        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            int rowi = dgProveedores.CurrentRow.Index;
            string valor = dgProveedores[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);

            frmEditarProveedor frmEditProv = new frmEditarProveedor();
            frmEditProv._ideditar = idedit;
            frmEditProv.Show();
            
            
            
        }

        private void ProveedoresVer_Activated(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();

            dgProveedores.DataSource = proveedores.getProveedoresDG(conectar.con);
        }
    }
}

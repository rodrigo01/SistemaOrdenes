using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaOrdenes
{
    public partial class Menumain : Form
    {
        public Menumain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_SistemaDataSet3.Ordenes' table. You can move, or remove it, as needed.
            this.ordenesTableAdapter1.Fill(this.bD_SistemaDataSet3.Ordenes);
            // TODO: This line of code loads data into the 'tbbid.Ordenes' table. You can move, or remove it, as needed.
            this.ordenesTableAdapter.Fill(this.tbbid.Ordenes);
            // TODO: This line of code loads data into the 'bD_SistemaDataSet2.Ordenes' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'bD_SistemaDataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.bD_SistemaDataSet.Proveedores);

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOrdenes.Visible = false;
            pnlProveedor.Visible = true;
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            frmNuevoProveedor frmNvoProv = new frmNuevoProveedor();
            frmNvoProv.Show();
            
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordenesTableAdapter1.FillBy(this.bD_SistemaDataSet3.Ordenes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlProveedor.Visible = false;
            pnlOrdenes.Visible = true;
        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaOrden frmNvoOrd = new frmNuevaOrden();
            frmNvoOrd.Show();
        }

 

    }
}

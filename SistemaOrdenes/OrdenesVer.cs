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
    public partial class OrdenesVer : Form
    {
        public OrdenesVer()
        {
            InitializeComponent();
        }

        private void OrdenesVer_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();

            dgOrdenes.DataSource = ordenes.getOrdenesDG(conectar.con);
            dgOrdenes.Columns["Total"].DefaultCellStyle.Format = "c";
            dgOrdenes.Columns["Fecha"].DefaultCellStyle.Format = "d";
            dgOrdenes.Columns["Nombre"].Width = 300;
            dgOrdenes.Columns["ID"].Visible = false;
        }

        private void btDetalles_Click(object sender, EventArgs e)
        {
            int idedit = 0;
            int rowi = dgOrdenes.CurrentRow.Index;
            string valor = dgOrdenes[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);

            frmVerOrden frmverorden = new frmVerOrden();
            frmverorden._idver = idedit;
            frmverorden.Show();
        }

        private void dgOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            if (tbValorB.Text.CompareTo("") != 0)
            {
                Conexion conectar = new Conexion();
                Ordenes ordenes = new Ordenes();

                dgOrdenes.DataSource = ordenes.getOrdenesDGCampo(cbBPor.GetItemText(cbBPor.SelectedItem), tbValorB.Text, conectar.con);
            }
            else
            {
                MessageBox.Show("El Valor de la busqueda no puede estar vacio");
            }
            
        }

        private void OrdenesVer_Activated(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();

            dgOrdenes.DataSource = ordenes.getOrdenesDG(conectar.con);
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();

            dgOrdenes.DataSource = ordenes.getOrdenesDG(conectar.con);
        }

        private void btReporte_Click(object sender, EventArgs e)
        {
            frmOrdenesSeleccion frmOrdSele = new frmOrdenesSeleccion();
            frmOrdSele.Show();
        }
    }
}

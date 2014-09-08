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
            Proveedores proveedores = new Proveedores();

            AutoCompleteStringCollection listaNombres = new AutoCompleteStringCollection();
            listaNombres = proveedores.getProveedoresAutoComplete(conectar.con);
            tbValorB.AutoCompleteCustomSource = listaNombres;
            
            dgOrdenes.DataSource = ordenes.getOrdenesDG(conectar.con);
            
            dgOrdenes.Columns["Total"].DefaultCellStyle.Format = "c";
            dgOrdenes.Columns["Fecha"].DefaultCellStyle.Format = "d";
            dgOrdenes.Columns["Nombre"].Width = 300;
            dgOrdenes.Columns["ID"].Visible = false;
            
            

            this.dgOrdenes.CellFormatting +=
new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            //dgOrdenes.Columns["Estado"].Visible = false;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            int idedit = 0;
            int rowi = dgOrdenes.CurrentRow.Index;
            string norden = dgOrdenes[1, rowi].Value.ToString();
            string valor = dgOrdenes[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);
            DialogResult dialogResult = MessageBox.Show("Deseas Cancelar la orden #" + norden + " ?", "Aviso!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Conexion conectar = new Conexion();
                Ordenes ordenes = new Ordenes();

                ordenes.setCancel(idedit, conectar.con);

                MessageBox.Show("Orden Cancelada");
            }

        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex == this.dgOrdenes.Columns["Estado"].Index)
            {
                if (e.Value != null)
                {
                    string CNumColour = e.Value.ToString();

                    if (CNumColour.CompareTo("cancelado")==0)
                    {
                        this.dgOrdenes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        ///this.dgOrdenes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Pink;
                    }
                }
            }
        }
    }
}

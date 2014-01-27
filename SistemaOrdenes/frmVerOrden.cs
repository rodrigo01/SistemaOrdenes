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
    public partial class frmVerOrden : Form
    {
        public int _idver = 0;
        public frmVerOrden()
        {
            InitializeComponent();
        }

        private void frmVerOrden_Load(object sender, EventArgs e)
        {
            int idver = _idver;
            Conexion conectar = new Conexion();
            Ordenes orden = new Ordenes();
            Proveedores proveedores = new Proveedores();
            DataTable dtLista = new DataTable();

            
            orden.getOrden(idver, conectar.con);
            
            if (orden.id != 0)
            {
                //datos de Proveedor
                proveedores.getProveedor(orden.id_proveedor, conectar.con);

                //cargamos informacion de orden
                tbOrden.Text = orden.orden.ToString();

                //no traemos detalles de Orden
                dgDetallesOrden.DataSource = orden.getDetallesOrden(orden.id, conectar.con);
                
                dgDetallesOrden.Columns["Descripcion"].Width = 300;
                dgDetallesOrden.Columns["Cantidad"].Width = 50;
                dgDetallesOrden.Columns["Costo"].Width = 80;
                dgDetallesOrden.Columns["Precio"].Width = 80;
                dgDetallesOrden.Columns["Costo"].DefaultCellStyle.Format = "c";
                dgDetallesOrden.Columns["Precio"].DefaultCellStyle.Format = "c";
                
                //actualizamos totales
                actualizartotales();

                //cargamos lista de proveedores
                dtLista = proveedores.getProveedoresDG(conectar.con);
                cbProveedores.DataSource = dtLista;
                
                //definimos proveedor de lista
                cbProveedores.SelectedIndex = cbProveedores.FindString(proveedores.nombre);
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Proveedor Inexistente " + idver);
            }

        }

        public void actualizartotales()
        {
            
            float subtotal = 0;
            float civa = 0;
            float iva = 0;
            float total = 0;
            int cant = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgDetallesOrden.Rows)
            {

                if (row.Cells["Cantidad"].Value != null)
                {
                    if (row.Cells["Precio"].Value.ToString().Equals("") == false)
                        subtotal += Convert.ToInt32(row.Cells["Costo"].Value);
                }
             
            }
           
            tbSubTotal.Text = subtotal.ToString("C");
            if (tbPIva.Text.Length==0)
                tbPIva.Text = "0";
            civa = Convert.ToInt32(tbPIva.Text);
            iva = subtotal * (civa/100);
            tbIva.Text = iva.ToString("C");
            total = iva + subtotal;
            tbTotal.Text = total.ToString("C");
        }

        public void actualizarmulti()
        {
            foreach (DataGridViewRow row in dgDetallesOrden.Rows)
            {
                if (row.Cells["Cantidad"].Value != null )
                {
                    if(row.Cells["Precio"].Value.ToString().Equals("")==false)
                    row.Cells["Costo"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(row.Cells["Precio"].Value.ToString());
                }

            }
        }

        private void dgDetallesOrden_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgDetallesOrden_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actualizarmulti();
            actualizartotales();
        }

        private void tbPIva_TextChanged(object sender, EventArgs e)
        {
            actualizarmulti();
            actualizartotales();
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

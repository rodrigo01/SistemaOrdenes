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
            // si encontramos la orden
            if (orden.id != 0)
            {
                //datos de Proveedor
                proveedores.getProveedor(orden.id_proveedor, conectar.con);

                //cargamos informacion de orden
                tbOrden.Text = orden.orden.ToString();
                dtFecha.Value = Convert.ToDateTime(orden.fecha);
                tbUso.Text = orden.parauso;
                tbDepartamento.Text = orden.departamento;
                tbObra.Text = orden.obra;
                //cbVehiculo = 
                tbMaquina.Text = orden.maquina;
                tbUnidad.Text = orden.unidad;
                tbAlmacen.Text = orden.almacen;
                
                //tbProyecto.Text = orden.p

                //no traemos detalles de Orden
                dgDetallesOrden.DataSource = orden.getDetallesOrden(orden.id, conectar.con);
                
                //detalles de estilo
                dgDetallesOrden.Columns["Descripcion"].Width = 500;
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
                cbProveedores.DisplayMember = "nombre";
                cbProveedores.ValueMember = "id";
                
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes Orden = new Ordenes();
            Proveedores Proveedor = new Proveedores();

            //guardamos datos en Objeto
            Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);
            Orden.id = _idver;
            Orden.id_proveedor = Proveedor.id;
            Orden.orden = Convert.ToInt32(tbOrden.Text);
            Orden.fecha = dtFecha.Value.ToShortDateString();
            Orden.departamento = tbDepartamento.Text;
            Orden.vehiculo = cbVehiculo.SelectedText;
            Orden.almacen = tbAlmacen.Text;
            Orden.parauso = tbUso.Text;
            Orden.maquina = tbMaquina.Text;
            Orden.obra = tbObra.Text;
            Orden.unidad = tbUnidad.Text;

            // Actualizamos Orden
            Orden.updateOrden(Orden, conectar.con);
            
            // Tiramos Detalles Orden
            Orden.deleteDetalles(_idver,conectar.con);

            //Regeneramos Detalles Orden
            Detalles detalle = new Detalles();
            detalle.id_orden = _idver;
            foreach (DataGridViewRow row in dgDetallesOrden.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    if (row.Cells["Precio"].Value.ToString().Equals("") == false)
                    {
                        detalle.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                        detalle.descripcion = row.Cells["Descripcion"].Value.ToString();
                        detalle.punitario = Convert.ToSingle(row.Cells["Precio"].Value.ToString());

                        //insertamos detalle
                        Orden.insertDetalle(detalle,conectar.con);
                    }
                }

            }

            //finalizado
            System.Windows.Forms.MessageBox.Show("Orden Actualizada");
        }

        private void btImprimi_Click(object sender, EventArgs e)
        {
            ImprimirOrden printOrden = new ImprimirOrden();

            printOrden.Show();
        }



    }
}

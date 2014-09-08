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
    public partial class frmNuevaOrden : Form
    {
        int isloaded = 0;
        public frmNuevaOrden()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevaOrden_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;
            DataTable dtLista = new DataTable();

            Ordenes ordenes = new Ordenes();
            Departamentos departamentos = new Departamentos();
            departamentos.con = conectar.con;
            

            int lastorden = 0;
            //System.Windows.Forms.MessageBox.Show("Nu" + lastorden);
            lastorden = ordenes.getLastNoOrden(conectar.con);

            lastorden++;
            
            tbOrden.Text = lastorden.ToString();

            //Cargamos Lista de Proveedores
            dtLista = proveedores.getProveedoresDG(conectar.con);
            cbProveedores.DataSource = dtLista;
            cbProveedores.DisplayMember = "Nombre";
            cbProveedores.ValueMember = "Nombre";

            //Cargamos Lista de Departamentos
            dtLista = departamentos.getDepartamentosDG();
            cbDepartamento.DataSource = dtLista;
            cbDepartamento.DisplayMember = "nombre";
            cbDepartamento.ValueMember = "id";

            //Cargamos Lista de Vehiculos
            dtLista = vehiculos.getVehiculosByClase("V");
            cbVehiculo.DataSource = dtLista;
            cbVehiculo.DisplayMember = "noecon";
            cbVehiculo.ValueMember = "id";

            //cargamos lista de maquinaria
            dtLista = vehiculos.getVehiculosByClase("M");
            cbMaquina.DataSource = dtLista;
            cbMaquina.DisplayMember = "noecon";
            cbMaquina.ValueMember = "id";

            //detalles de estilo
            dgDetallesOrden.Columns["Descripcion"].Width = 500;
            dgDetallesOrden.Columns["Cantidad"].Width = 50;
            dgDetallesOrden.Columns["Costo"].Width = 80;
            dgDetallesOrden.Columns["Precio"].Width = 80;
            dgDetallesOrden.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgDetallesOrden.Columns["Precio"].DefaultCellStyle.Format = "c";

            isloaded = 1;
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
                    if (row.Cells["Precio"].Value != null)
                    {
                        if (row.Cells["Precio"].Value.ToString().Equals("") == false)
                            subtotal += Convert.ToSingle(row.Cells["Costo"].Value);
                    }
                    
                }

            }

            tbSubTotal.Text = subtotal.ToString("C");
            if (tbPIva.Text.Length == 0)
                tbPIva.Text = "0";
            civa = Convert.ToSingle(tbPIva.Text);
            iva = subtotal * (civa / 100);
            tbIva.Text = iva.ToString("C");
            total = iva + subtotal;
            tbTotal.Text = total.ToString("C");
        }

        public void actualizarmulti()
        {
            foreach (DataGridViewRow row in dgDetallesOrden.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    if (row.Cells["Precio"].Value!= null)
                    {
                        if (row.Cells["Precio"].Value.ToString().Equals("") == false)
                            row.Cells["Costo"].Value = Convert.ToSingle(row.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(row.Cells["Precio"].Value.ToString());
                    }
                    
                }

            }
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

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {

            if (tbOrden.Text.CompareTo("")==0)
            {
                System.Windows.Forms.MessageBox.Show("No se puede dejar vacio el Numero de Orden");
            }
            else
            {
                Conexion conectar = new Conexion();
                Ordenes Orden = new Ordenes();
                Proveedores Proveedor = new Proveedores();

                //guardamos datos en Objeto
                Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);

                Orden.id_proveedor = Proveedor.id;
                Orden.orden = Convert.ToInt32(tbOrden.Text);
                Orden.fecha = dtFecha.Value.ToShortDateString();
                Orden.departamento = cbDepartamento.GetItemText(cbDepartamento.SelectedItem); ;
                Orden.vehiculo = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
                Orden.almacen = tbAlmacen.Text;
                Orden.parauso = tbUso.Text;
                Orden.maquina = cbMaquina.GetItemText(cbMaquina.SelectedItem); ;
                Orden.obra = tbObra.Text;
                Orden.unidad = tbUnidad.Text;
                Orden.iva = Convert.ToInt32(tbPIva.Text);

                // Insertamos Orden
                int IDGEN = 0;
                IDGEN = Orden.insertOrden(Orden, conectar.con);
                //System.Windows.Forms.MessageBox.Show("Orden ID: " + IDGEN);

                //Regeneramos Detalles Orden
                Detalles detalle = new Detalles();
                detalle.id_orden = IDGEN;
                foreach (DataGridViewRow row in dgDetallesOrden.Rows)
                {
                    if (row.Cells["Cantidad"].Value != null)
                    {
                        if (row.Cells["Precio"].Value.ToString().Equals("") == false)
                        {
                            detalle.cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                            detalle.descripcion = row.Cells["Descripcion"].Value.ToString();
                            detalle.punitario = Convert.ToSingle(row.Cells["Precio"].Value.ToString());
                            detalle.moneda = tbMoneda.Text;
                            //System.Windows.Forms.MessageBox.Show("dato: " + detalle.punitario);

                            //insertamos detalle
                            Orden.insertDetalle(detalle, conectar.con);
                        }
                    }

                }

                //finalizado
                System.Windows.Forms.MessageBox.Show("Orden Insertada");

                frmVerOrden frmOrden = new frmVerOrden();
                frmOrden._idver = IDGEN;
                frmOrden.Show();

                this.Close();
            }



           
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDetallesOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tbMoneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isloaded == 1)
            {
                Conexion conectar = new Conexion();
                Vehiculos vehiculos = new Vehiculos();
                vehiculos.con = conectar.con;

                String vehiculoSet = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
                if (vehiculoSet != "")
                {
                    vehiculos.getVehiculoNoEcon(vehiculoSet);
                    //String maquina = cbMaquina.GetItemText(cbMaquina.SelectedItem); ;

                    //System.Windows.Forms.MessageBox.Show("Se cambio");
                    tbUso.Text = vehiculos.marca + " " + vehiculos.modelo + " " + vehiculos.usuario + " # " + tbUso.Text;
                }

                
            }
            
        }

        private void tbUso_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isloaded == 1)
            {
                Conexion conectar = new Conexion();
                Vehiculos vehiculos = new Vehiculos();
                vehiculos.con = conectar.con;

                //String vehiculoSet = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
                String maquinaSet = cbMaquina.GetItemText(cbMaquina.SelectedItem);
                if (maquinaSet != "")
                {

                    vehiculos.getVehiculoNoEcon(maquinaSet);


                    //System.Windows.Forms.MessageBox.Show("Se cambio");
                    tbUso.Text = vehiculos.marca + " " + vehiculos.modelo + " " + vehiculos.usuario + " # " + tbUso.Text;
                }
            }
        }


    }
}

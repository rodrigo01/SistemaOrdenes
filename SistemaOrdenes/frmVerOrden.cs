﻿using System;
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
        public int _idorden = 0;
        public int _iddetalles = 0;
        public int _idproveedor = 0;
        public float estetotal = 0;

        public float _subtotal;
        public float _iva;
        public float _total;

        public frmVerOrden()
        {
            InitializeComponent();
        }

        private void frmVerOrden_Load(object sender, EventArgs e)
        {
            int idver = _idver;
            Conexion conectar = new Conexion();
            Ordenes orden = new Ordenes();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;
            Proveedores proveedores = new Proveedores();
            DataTable dtLista = new DataTable();

            
            orden.getOrden(idver, conectar.con);
            String moneda = orden.getDetallesMoneda(idver, conectar.con);
            tbMoneda.Text = moneda;
            // si encontramos la orden
            if (orden.id != 0)
            {
                _idorden = orden.id; //definimos id para reporte
                //datos de Proveedor
                proveedores.getProveedor(orden.id_proveedor, conectar.con);
                

                //cargamos informacion de orden
                tbOrden.Text = orden.orden.ToString();
                dtFecha.Value = Convert.ToDateTime(orden.fecha);
                tbUso.Text = orden.parauso;
                tbDepartamento.Text = orden.departamento;
                tbObra.Text = orden.obra;
                //cbVehiculo = 
                //tbMaquina.Text = orden.maquina;
                tbUnidad.Text = orden.unidad;
                tbAlmacen.Text = orden.almacen;
                tbPIva.Text = orden.iva.ToString();
                
                //tbProyecto.Text = orden.p

                //no traemos detalles de Orden
                dgDetallesOrden.DataSource = orden.getDetallesOrden(orden.id, conectar.con);
                _iddetalles = orden.id; //definimos id detalles
                
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
                proveedores.getProveedorByName(proveedores.nombre, conectar.con);
                _idproveedor = proveedores.id; //definimos id de proveedor

                dtLista = proveedores.getProveedoresDG(conectar.con);
                cbProveedores.DataSource = dtLista;
                cbProveedores.DisplayMember = "nombre";
                cbProveedores.ValueMember = "id";
                
                //definimos proveedor de lista
                cbProveedores.SelectedIndex = cbProveedores.FindString(proveedores.nombre);
                

                //cargamos lista de Vehiculos
                dtLista = vehiculos.getVehiculosByClase("V");
                
                cbVehiculo.DataSource = dtLista;
                cbVehiculo.DisplayMember = "noecon";
                cbVehiculo.ValueMember = "id";

                //definimos vehiculo
                cbVehiculo.SelectedIndex = cbVehiculo.FindString(orden.vehiculo);


                //cargamos lista de maquinaria
                dtLista = vehiculos.getVehiculosByClase("M");

                cbMaquina.DataSource = dtLista;
                cbMaquina.DisplayMember = "noecon";
                cbMaquina.ValueMember = "id";


                //definimos maquinaria
                if (orden.maquina.Equals(""))
                {
                    cbMaquina.SelectedIndex = cbMaquina.FindString(orden.vehiculo);
                }
                else
                {
                    cbMaquina.SelectedIndex = cbMaquina.FindString(orden.maquina);
                }
                
                
                
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
                        subtotal += Convert.ToSingle(row.Cells["Costo"].Value);
                }
             
            }
           
            tbSubTotal.Text = subtotal.ToString("C");
            _subtotal = subtotal;
            if (tbPIva.Text.Length==0)
                tbPIva.Text = "0";
            civa = Convert.ToSingle(tbPIva.Text);
            iva = subtotal * (civa/100);
            _iva = iva;
            tbIva.Text = iva.ToString("C");
            total = iva + subtotal;
            tbTotal.Text = total.ToString("C");
            estetotal = total;
            _total = total;
        }

        public void actualizarmulti()
        {
            foreach (DataGridViewRow row in dgDetallesOrden.Rows)
            {
                if (row.Cells["Cantidad"].Value != null )
                {
                    if(row.Cells["Precio"].Value.ToString().Equals("")==false)
                        row.Cells["Costo"].Value = Convert.ToSingle(row.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(row.Cells["Precio"].Value.ToString());
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
            Orden.vehiculo = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
            Orden.almacen = tbAlmacen.Text;
            Orden.parauso = tbUso.Text;
            Orden.maquina = cbMaquina.GetItemText(cbMaquina.SelectedItem);
            Orden.obra = tbObra.Text;
            Orden.unidad = tbUnidad.Text;
            Orden.iva = Convert.ToInt32(tbPIva.Text);

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
                        detalle.cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                        detalle.descripcion = row.Cells["Descripcion"].Value.ToString();
                        detalle.punitario = Convert.ToSingle(row.Cells["Precio"].Value.ToString());
                        detalle.moneda = tbMoneda.Text;
                        //insertamos detalle
                        Orden.insertDetalle(detalle,conectar.con);
                    }
                }

            }

            //finalizado
            System.Windows.Forms.MessageBox.Show("Orden Actualizada");
            frmNuevaOrden frmNueva = new frmNuevaOrden();
            frmNueva.Show();
            this.Close();
        }

        private void btImprimi_Click(object sender, EventArgs e)
        {
            ImprimirOrden printOrden = new ImprimirOrden();
            printOrden._idorden = _idorden;
            printOrden._iddetalles = _iddetalles;
            printOrden._idproveedor = _idproveedor;
            printOrden._subtotal = _subtotal;
            printOrden._iva = _iva;
            printOrden._total = _total;

            Numalet let = new Numalet();
            //al uso en México (creo):
            
            if (tbMoneda.Text.Equals("DOLARES"))
            {
                let.MascaraSalidaDecimal = "00/100";
                let.SeparadorDecimalSalida = "dolares";
            }
            else
            {
                let.MascaraSalidaDecimal = "00/100 M.N.";
                let.SeparadorDecimalSalida = "pesos";
            }
            
            //observar que sin esta propiedad queda "veintiuno pesos" en vez de "veintiún pesos":
            let.ApocoparUnoParteEntera = true;
            
            //Son: un mil ciento veintiún pesos 24/100 M.N.
            //float fe = (float)Convert.ToDouble(tbTotal.Text);
            frmNuevaOrden frmNueva = new frmNuevaOrden();
            frmNueva.Show();
            if (chbLetra.Checked)
            {
                printOrden._conletra = let.ToCustomCardinal(estetotal).ToUpper();
            }
            else
            {
                printOrden._conletra = "";
            }
            
            printOrden.Show();
            
            this.Close();
        }

        private void tbMoneda_TextChanged(object sender, EventArgs e)
        {

        }





    }
}

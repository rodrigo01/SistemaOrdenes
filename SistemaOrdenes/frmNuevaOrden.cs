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
    public partial class frmNuevaOrden : Form
    {
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
            DataTable dtLista = new DataTable();

            //Cargamos Lista de Proveedores
            dtLista = proveedores.getProveedoresDG(conectar.con);
            cbProveedores.DataSource = dtLista;
            cbProveedores.DisplayMember = "nombre";
            cbProveedores.ValueMember = "id";

            //detalles de estilo
            dgDetallesOrden.Columns["Descripcion"].Width = 500;
            dgDetallesOrden.Columns["Cantidad"].Width = 50;
            dgDetallesOrden.Columns["Costo"].Width = 80;
            dgDetallesOrden.Columns["Precio"].Width = 80;
            dgDetallesOrden.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgDetallesOrden.Columns["Precio"].DefaultCellStyle.Format = "c";
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
                        subtotal += Convert.ToInt32(row.Cells["Costo"].Value);
                    }
                    
                }

            }

            tbSubTotal.Text = subtotal.ToString("C");
            if (tbPIva.Text.Length == 0)
                tbPIva.Text = "0";
            civa = Convert.ToInt32(tbPIva.Text);
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
                            row.Cells["Costo"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()) * Convert.ToSingle(row.Cells["Precio"].Value.ToString());
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
            Conexion conectar = new Conexion();
            Ordenes Orden = new Ordenes();
            Proveedores Proveedor = new Proveedores();

            //guardamos datos en Objeto
            Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);

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

            // Insertamos Orden
            int IDGEN = 0;
            IDGEN = Orden.insertOrden(Orden, conectar.con);
            System.Windows.Forms.MessageBox.Show("Orden ID: " + IDGEN);

            //Regeneramos Detalles Orden
            Detalles detalle = new Detalles();
            detalle.id_orden = IDGEN;
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
                        Orden.insertDetalle(detalle, conectar.con);
                    }
                }

            }

            //finalizado
            System.Windows.Forms.MessageBox.Show("Orden Insertada");
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SistemaOrdenes
{
    public partial class ImprimirOrden : Form
    {
        public int _iddetalles;
        public int _idorden;
        public int _idproveedor;
        public String _conletra;
        public float _subtotal;
        public float _iva;
        public float _total;


        public ImprimirOrden()
        {
            InitializeComponent();
        }

        private void ImprimirOrden_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            int iddetalles = _iddetalles;
            int idorden = _idorden;
            int idproveedor = _idproveedor;
            String conletra = _conletra;
            float subtotal = _subtotal;
            float iva = _iva;
            float total = _total;

            // TODO: This line of code loads data into the 'ReporteP.Ordenes' table. You can move, or remove it, as needed.
            //this.OrdenesTableAdapter.Fill(this.ReporteP.Ordenes);
            //this.OrdenesTableAdapter.Fill()

            // TODO: This line of code loads data into the 'BD_SistemaDataSet2.Detalles_Orden' table. You can move, or remove it, as needed.
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();
            Vehiculos vehiculos = new Vehiculos();

            
            

            //Detalles_OrdenBindingSource.DataSource = ordenes.getDetallesOrden(9680,conectar.con);
           //Detalles_OrdenBindingSource
            //this.Detalles_OrdenTableAdapter.Fill(this.BD_SistemaDataSet2.Detalles_Orden);
            // TODO: This line of code loads data into the 'bD_SistemaDataSet.Proveedores' table. You can move, or remove it, as needed.
            //this.proveedoresTableAdapter.Fill(this.bD_SistemaDataSet.Proveedores);

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Detalles", ordenes.getDetallesOrdenRep(iddetalles, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            source = new ReportDataSource("OrdenInfo", ordenes.getOrdenRep(idorden, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            source = new ReportDataSource("Proveedor", ordenes.getProveedoresRep(idproveedor, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            ordenes.getOrden(idorden, conectar.con);
           String detallevehiculo = "";

           //MessageBox.Show(ordenes.vehiculo, "Aviso!");
           if (ordenes.vehiculo.ToString().Length>0)
            {
                vehiculos.con = conectar.con;
                vehiculos.getVehiculoNoEcon(ordenes.vehiculo);
                detallevehiculo = vehiculos.marca + " " + vehiculos.modelo + " " + vehiculos.usuario;
            }
           
            

            ReportParameter[] parameters = new ReportParameter[5];
            parameters[0] = new ReportParameter("CantidadLetra", conletra);
            parameters[1] = new ReportParameter("subtotal", subtotal.ToString());
            parameters[2] = new ReportParameter("iva", iva.ToString());
            parameters[3] = new ReportParameter("total", total.ToString());
            parameters[4] = new ReportParameter("detallevehiculo", detallevehiculo);
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

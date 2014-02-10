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
        public ImprimirOrden()
        {
            InitializeComponent();
        }

        private void ImprimirOrden_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteP.Ordenes' table. You can move, or remove it, as needed.
            this.OrdenesTableAdapter.Fill(this.ReporteP.Ordenes);
            //this.OrdenesTableAdapter.Fill()

            // TODO: This line of code loads data into the 'BD_SistemaDataSet2.Detalles_Orden' table. You can move, or remove it, as needed.
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();



            //Detalles_OrdenBindingSource.DataSource = ordenes.getDetallesOrden(9680,conectar.con);
           //Detalles_OrdenBindingSource
            //this.Detalles_OrdenTableAdapter.Fill(this.BD_SistemaDataSet2.Detalles_Orden);
            // TODO: This line of code loads data into the 'bD_SistemaDataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.bD_SistemaDataSet.Proveedores);

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Detalles", ordenes.getDetallesOrdenRep(9680, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            source = new ReportDataSource("OrdenInfo", ordenes.getDetallesOrdenRep(9680, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            source = new ReportDataSource("Proveedor", ordenes.getProveedoresRep(725, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);
            
            
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

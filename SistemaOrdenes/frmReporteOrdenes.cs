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
    public partial class frmReporteOrdenes : Form
    {
        public int _idver = 0;
        public frmReporteOrdenes()
        {
            InitializeComponent();
        }

        private void frmReporteOrdenes_Load(object sender, EventArgs e)
        {

            int idprov = _idver;

            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();


            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("ConReporteTabla", ordenes.getOrdenesDetallesProveedorDG(idprov,conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            source = new ReportDataSource("Proveedor", ordenes.getProveedoresRep(idprov, conectar.con));
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class frmReporteVehiculos : Form
    {
        public String _departamento;
        public frmReporteVehiculos()
        {
            InitializeComponent();
        }

        private void frmReporteVehiculos_Load(object sender, EventArgs e)
        {

            String departamento = _departamento;

            Conexion conectar = new Conexion();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Vehiculos", vehiculos.getVehiculosByDepartamentoDG(departamento));
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}

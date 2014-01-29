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
            // TODO: This line of code loads data into the 'bD_SistemaDataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.bD_SistemaDataSet.Proveedores);
            // TODO: This line of code loads data into the 'ReporteP.Detalles_Orden' table. You can move, or remove it, as needed.
            this.Detalles_OrdenTableAdapter.Fill(this.ReporteP.Detalles_Orden);

            this.reportViewer1.RefreshReport();
        }
    }
}

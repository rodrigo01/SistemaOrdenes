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
    public partial class OrdenesVer : Form
    {
        public OrdenesVer()
        {
            InitializeComponent();
        }

        private void OrdenesVer_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes ordenes = new Ordenes();

            dgOrdenes.DataSource = ordenes.getOrdenesDG(conectar.con);
            dgOrdenes.Columns["Total"].DefaultCellStyle.Format = "c";
            dgOrdenes.Columns["Fecha"].DefaultCellStyle.Format = "d";
            dgOrdenes.Columns["Nombre"].Width = 300;
            dgOrdenes.Columns["ID"].Visible = false;
        }

        private void btDetalles_Click(object sender, EventArgs e)
        {
            int idedit = 0;
            int rowi = dgOrdenes.CurrentRow.Index;
            string valor = dgOrdenes[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);

            frmEditarProveedor frmEditProv = new frmEditarProveedor();
            frmEditProv._ideditar = idedit;
            frmEditProv.Show();
        }
    }
}

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
    public partial class ProveedoresVer : Form
    {
        public ProveedoresVer()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            frmNuevoProveedor frmNvoProv = new frmNuevoProveedor();
            frmNvoProv.Show();
        }
    }
}

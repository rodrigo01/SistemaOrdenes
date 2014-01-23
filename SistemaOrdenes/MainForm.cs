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
    public partial class Menumain : Form
    {
        public Menumain()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProveedoresVer proveedoresVer = new ProveedoresVer();
            proveedoresVer.Show();
        }
      

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaOrden frmNvoOrd = new frmNuevaOrden();
            frmNvoOrd.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenesVer ordenesVer = new OrdenesVer();
            ordenesVer.Show();
        }

        private void Menumain_Load(object sender, EventArgs e)
        {

        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 

    }
}

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
    public partial class frmReporteVehDep : Form
    {
        public frmReporteVehDep()
        {
            InitializeComponent();
        }

        private void frmReporteVehDep_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Departamentos departamentos = new Departamentos();
            departamentos.con = conectar.con;
            DataTable dtLista = new DataTable();

            dtLista = departamentos.getDepartamentosDG();
            cbDepartamentos.DataSource = dtLista;
            cbDepartamentos.DisplayMember = "Nombre";
            cbDepartamentos.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            frmReporteVehiculos frmRepVeh = new frmReporteVehiculos();
            frmRepVeh._departamento = cbDepartamentos.GetItemText(cbDepartamentos.SelectedItem);
            frmRepVeh.Show();
            //Proveedor.id;
            
        }
    }
}

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
    public partial class frmOrdenesSeleccion : Form
    {
        public frmOrdenesSeleccion()
        {
            InitializeComponent();
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Ordenes Orden = new Ordenes();
            Proveedores Proveedor = new Proveedores();

            //guardamos datos en Objeto
            Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);

            frmReporteOrdenes frmRepOrd = new frmReporteOrdenes();
            frmRepOrd._idver = Proveedor.id;
            frmRepOrd.Show();
            //Proveedor.id;
        }

        private void frmOrdenesSeleccion_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;
            DataTable dtLista = new DataTable();

            //Cargamos Lista de Proveedores
            dtLista = proveedores.getProveedoresDG(conectar.con);
            cbProveedores.DataSource = dtLista;
            cbProveedores.DisplayMember = "nombre";
            cbProveedores.ValueMember = "id";
        }
    }
}

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
    public partial class frmReportesPre : Form
    {
        public frmReportesPre()
        {
            InitializeComponent();
        }



        private void btGenerar_Click(object sender, EventArgs e)
        {
            frmReporteVehiculos frmRepVeh = new frmReporteVehiculos();
            frmRepVeh._departamento = cbDepartamentos.GetItemText(cbDepartamentos.SelectedItem);
            frmRepVeh.Show();
            //Proveedor.id;
        }



        private void frmReportesPre_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Departamentos departamentos = new Departamentos();
            Proveedores proveedores = new Proveedores();
            departamentos.con = conectar.con;
            DataTable dtLista = new DataTable();

            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;

            dtLista = departamentos.getDepartamentosDG();
            cbDepartamentos.DataSource = dtLista;
            cbDepartamentos.DisplayMember = "Nombre";
            cbDepartamentos.ValueMember = "Id";

            //Cargamos Lista de Proveedores
            dtLista = proveedores.getProveedoresDG(conectar.con);
            cbProveedores.DataSource = dtLista;
            cbProveedores.DisplayMember = "nombre";
            cbProveedores.ValueMember = "id";

            //Cargamos Lista de Vehiculos
            dtLista = vehiculos.getVehiculosByClase("V");
            cbVehiculo.DataSource = dtLista;
            cbVehiculo.DisplayMember = "noecon";
            cbVehiculo.ValueMember = "id";

            //cargamos lista de maquinaria
            dtLista = vehiculos.getVehiculosByClase("M");
            cbMaquina.DataSource = dtLista;
            cbMaquina.DisplayMember = "noecon";
            cbMaquina.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlserch = "SELECT Ordenes.orden, Vehiculos.noecon, Vehiculos.marca, Vehiculos.modelo, Vehiculos.clase, Vehiculos.placas, Proveedores.nombre FROM Vehiculos INNER JOIN (Proveedores INNER JOIN Ordenes ON Proveedores.Id = Ordenes.id_proveedor) ON Vehiculos.noecon = Ordenes.vehiculo WHERE (((Vehiculos.noecon)=\"001-P-OP\")) ORDER BY Ordenes.orden DESC;";
        }
    }
}

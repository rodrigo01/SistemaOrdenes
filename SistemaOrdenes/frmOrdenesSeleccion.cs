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

        private void button2_Click(object sender, EventArgs e)
        {
            //reporte con vehiculos
            Conexion conectar = new Conexion();
            Ordenes Orden = new Ordenes();
            Proveedores Proveedor = new Proveedores();
            

            if (chbTodosV.Checked)
            {
                frmReporteOrdenesVehiculos frmRepOrd = new frmReporteOrdenesVehiculos();
                frmRepOrd._idver = 0;
                String vehicuulosel = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
                frmRepOrd._vehiculo = vehicuulosel;
                frmRepOrd.Show();
                
            }
            else
            {
                frmReporteOrdenes frmRepOrd = new frmReporteOrdenes();
                //guardamos datos en Objeto
                Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);                
                frmRepOrd._idver = Proveedor.id;
                String vehicuulosel = cbVehiculo.GetItemText(cbVehiculo.SelectedItem);
                frmRepOrd._vehiculo = vehicuulosel;
                frmRepOrd.Show();
            }

            
            //Proveedor.id;
        }

        private void btnGenerarM_Click(object sender, EventArgs e)
        {
            //reporte con vehiculos
            Conexion conectar = new Conexion();
            Ordenes Orden = new Ordenes();
            Proveedores Proveedor = new Proveedores();
            frmReporteOrdenes frmRepOrd = new frmReporteOrdenes();

            if (chbTodosM.Checked)
            {
                frmRepOrd._idver = 0;
            }
            else
            {
                //guardamos datos en Objeto
                Proveedor.getProveedorByName(cbProveedores.GetItemText(cbProveedores.SelectedItem), conectar.con);
                frmRepOrd._idver = Proveedor.id;
            }

            String vehicuulosel = cbMaquina.GetItemText(cbMaquina.SelectedItem);
            frmRepOrd._vehiculo = vehicuulosel;
            frmRepOrd.Show();
            //Proveedor.id;
        }
    }
}

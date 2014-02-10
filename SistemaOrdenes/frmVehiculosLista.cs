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
    public partial class frmVehiculosLista : Form
    {
        public frmVehiculosLista()
        {
            InitializeComponent();
        }

        private void frmVehiculosLista_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;

            dgVehiculos.DataSource = vehiculos.getVehiculosDG();
            dgVehiculos.Columns["ID"].Width = 40;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idedit = 0;
            int rowi = dgVehiculos.CurrentRow.Index;
            string valor = dgVehiculos[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);

            frmEditarVehiculos frmEditVehi= new frmEditarVehiculos();
            frmEditVehi._idver = idedit;
            frmEditVehi.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoVehiculo frmNuevoVehi = new frmNuevoVehiculo();
            frmNuevoVehi.Show();
        }

        private void frmVehiculosLista_Activated(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;

            dgVehiculos.DataSource = vehiculos.getVehiculosDG();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.con = conectar.con;

            dgVehiculos.DataSource = vehiculos.getVehiculosByNameDG(tbBuscar.Text);
        }
    }
}

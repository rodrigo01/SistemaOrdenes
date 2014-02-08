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
            
        }
    }
}

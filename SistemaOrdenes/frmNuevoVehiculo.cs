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
    public partial class frmNuevoVehiculo : Form
    {
        public frmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.con = conectar.con;

            if (tbModelo.Text.CompareTo("")==0)
            {
                tbModelo.Text = "" + 0;
            }

            vehiculo.noecon = tbNoEconomico.Text;
            vehiculo.marca = tbMarca.Text;
            vehiculo.modelo = Convert.ToInt32(tbModelo.Text);
            vehiculo.linea = tbLinea.Text;
            vehiculo.tipo = tbTipo.Text;
            vehiculo.clase = tbClase.Text;
            vehiculo.usuario = tbUsuario.Text;

            vehiculo.insertVehiculo(vehiculo);
            System.Windows.Forms.MessageBox.Show("Vehiculo Agregado");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

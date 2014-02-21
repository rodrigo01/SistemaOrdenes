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
    public partial class frmEditarVehiculos : Form
    {
        public int _idver;
        public frmEditarVehiculos()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarVehiculos_Load(object sender, EventArgs e)
        {
            int ideditar = _idver;
            //System.Windows.Forms.MessageBox.Show("ID " + ideditar);
            Conexion conectar = new Conexion();
            Vehiculos vehiculo= new Vehiculos();
            vehiculo.con = conectar.con;

            vehiculo.getVehiculo(ideditar);

            tbNoEconomico.Text = vehiculo.noecon;
            tbMarca.Text = vehiculo.marca;
            tbModelo.Text = vehiculo.modelo.ToString();
            tbLinea.Text = vehiculo.linea;
            tbTipo.Text = vehiculo.tipo;
            tbClase.Text = vehiculo.clase;
            tbPlacas.Text = vehiculo.placas;
            tbSerie.Text = vehiculo.numserie;
            tbMotor.Text = vehiculo.motor;
            tbllantas.Text = vehiculo.llantas;
            tbBaja.Text = vehiculo.bajafecha;
            tbColor.Text = vehiculo.color;

        }

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.con = conectar.con;

            if (tbModelo.Text.CompareTo("") == 0)
            {
                tbModelo.Text = "" + 0;
            }

            vehiculo.id = _idver;
            vehiculo.noecon = tbNoEconomico.Text;
            vehiculo.marca = tbMarca.Text;
            vehiculo.modelo = Convert.ToInt32(tbModelo.Text);
            vehiculo.linea = tbLinea.Text;
            vehiculo.tipo = tbTipo.Text;
            vehiculo.clase = tbClase.Text;
            vehiculo.usuario = tbUsuario.Text;
            vehiculo.placas = tbPlacas.Text;
            vehiculo.numserie = tbSerie.Text;
            vehiculo.motor = tbMotor.Text;
            vehiculo.llantas = tbllantas.Text;
            vehiculo.bajafecha = tbBaja.Text;
            vehiculo.color = tbColor.Text;

            vehiculo.updateVehiculo(vehiculo);
            System.Windows.Forms.MessageBox.Show("Vehiculo Actualizado");

        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
            
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

      
    }
}

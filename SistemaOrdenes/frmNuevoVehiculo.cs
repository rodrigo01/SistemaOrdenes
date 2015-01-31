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
            Vehiculos vehiculoChk = new Vehiculos();
            vehiculo.con = conectar.con;
            vehiculoChk.con = conectar.con;

            vehiculoChk.getVehiculoByNoEcon(tbNoEconomico.Text);
            if (vehiculoChk.id != 0)
            {
                System.Windows.Forms.MessageBox.Show("Ya existe Numero Economico, ingresa uno diferente");
                noEconomicoAlert.Text = "Ya existe Numero Economico";
            }
            else
            {
                if (tbModelo.Text.CompareTo("") == 0)
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
                vehiculo.placas = tbPlacas.Text;
                vehiculo.numserie = tbSerie.Text;
                vehiculo.motor = tbMotor.Text;
                vehiculo.llantas = tbllantas.Text;
                vehiculo.bajafecha = tbBaja.Text;
                vehiculo.color = tbColor.Text;
                vehiculo.departamento = cbDepartamentos.GetItemText(cbDepartamentos.SelectedItem);

                vehiculo.insertVehiculo(vehiculo);
                System.Windows.Forms.MessageBox.Show("Vehiculo Agregado");
                this.Close();
            }  
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

        private void frmNuevoVehiculo_Load(object sender, EventArgs e)
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

        private void tbModelo_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox) sender;

		    // Save the selected employee's name, because we will remove 
		    // the employee's name from the list. 
		    string selectedEmployee = (string) comboBox.SelectedItem;
            char let = selectedEmployee[0];
            tbClase.Text = let.ToString();
        }

        private void noEconomicoAlert_Click(object sender, EventArgs e)
        {

        }

        private void tbNoEconomico_TextChanged(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.con = conectar.con;

            vehiculo.getVehiculoByNoEcon(tbNoEconomico.Text);
            noEconomicoAlert.Text = "";
            if (vehiculo.id != 0)
            {
                noEconomicoAlert.Text = "Ya existe Numero Economico";
            }
            
        }
    }
}

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
        public int idedit;

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
            
            int rowi = dgVehiculos.CurrentRow.Index;
            string valor = dgVehiculos[0, rowi].Value.ToString();
            
            idedit = Convert.ToInt32(valor);
            //MessageBox.Show("Valor es: " + idedit);

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int rowi = dgVehiculos.CurrentRow.Index;
            string valor = dgVehiculos[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);
            DialogResult dialogResult = MessageBox.Show("Deseas dar de Baja?", "Aviso!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Conexion conectar = new Conexion();
                Vehiculos vehiculos = new Vehiculos();
                vehiculos.con = conectar.con;
                //MessageBox.Show("Se dara de baja:" +idedit );
                vehiculos.deletevehiculo(idedit);
                MessageBox.Show("Vehiculo dado de baja");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btReporte_Click(object sender, EventArgs e)
        {
            frmReporteVehDep frmVD = new frmReporteVehDep();
            frmVD.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas ejecutar limpieza?", "Aviso!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //primero nos traemos todos los vehiculos ordenados por NoEconomico
                Conexion conectar = new Conexion();
                Conexion conectar2 = new Conexion();
                Vehiculos vehiculos = new Vehiculos();
                Vehiculos vehiculosTemDel = new Vehiculos();
                vehiculos.con = conectar.con;
                vehiculosTemDel.con =  conectar2.con;
                System.Data.OleDb.OleDbDataReader lectura; //lecto de datos
                lectura = vehiculos.getVehiculosSortBy("noecon","asc");
                int id = 0;
                int idnuevo = 0;
                string noecon = "";
                int veces = 0;
                while (lectura.Read())
                {
                    if (noecon.CompareTo(lectura["noecon"].ToString()) != 0)
                    {
                        // osea que es diferente y no tiene relacion con el anterior
                        id = Convert.ToInt32(lectura["Id"].ToString());
                        noecon = lectura["noecon"].ToString();
                    }
                    else
                    {
                        //determina que el siguiente si es igual al guardado de modo que esta repetido
                        //ya que encontramos el id

                        idnuevo = Convert.ToInt32(lectura["Id"].ToString());
                        if (idnuevo > id)
                        {
                            vehiculosTemDel.hardDeleteVehiculo(id);
                            id = idnuevo;
                            noecon = lectura["noecon"].ToString();
                        }
                        else
                        {
                            vehiculosTemDel.hardDeleteVehiculo(idnuevo);

                        }
                        
                        veces++;
                    }
                }
                vehiculos.con.Close();

                MessageBox.Show("Se ha realizado un total de " + veces.ToString() + "cambios");
               
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}

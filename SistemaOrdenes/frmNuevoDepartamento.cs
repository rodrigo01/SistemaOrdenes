using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaOrdenes.Resources
{
    public partial class frmNuevoDepartamento : Form
    {
        public frmNuevoDepartamento()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Departamentos departamentos = new Departamentos();
            departamentos.con = conectar.con;

            departamentos.nombre = tbNombre.Text;
            departamentos.encargado = tbEncargado.Text;

            departamentos.insertDepartamento(departamentos);
            System.Windows.Forms.MessageBox.Show("Departamento Insertado");
            this.Close();
        }
    }
}

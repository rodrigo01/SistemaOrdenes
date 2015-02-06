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
    public partial class frmEditarDepartamento : Form
    {
        public int _ideditar;

        public frmEditarDepartamento()
        {
            InitializeComponent();
        }

        private void frmEditarDepartamento_Load(object sender, EventArgs e)
        {
            int ideditar = _ideditar;
            //System.Windows.Forms.MessageBox.Show("ID " + ideditar);
            Conexion conectar = new Conexion();
            Departamentos departamento = new Departamentos();
            departamento.con = conectar.con;

            departamento.getDepartamento(ideditar);

            tbNombre.Text = departamento.nombre;
            tbEncargado.Text = departamento.encargado;

            

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardarOrden_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Departamentos departamento = new Departamentos();
            departamento.con = conectar.con;

            departamento.id = _ideditar;
            departamento.nombre = tbNombre.Text;
            departamento.encargado = tbEncargado.Text;

            departamento.updateDepartamento(departamento);
            System.Windows.Forms.MessageBox.Show("Departamento Actualizado");
            this.Close();
        }
    }
}

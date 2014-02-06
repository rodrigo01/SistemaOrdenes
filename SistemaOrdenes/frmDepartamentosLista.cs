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
    public partial class frmDepartamentosLista : Form
    {
        public int idedit;

        public frmDepartamentosLista()
        {
            InitializeComponent();
        }

        private void frmDepartamentosLista_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Departamentos departamentos = new Departamentos();
            departamentos.con = conectar.con;

            dgDepartamentos.DataSource = departamentos.getDepartamentosDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int rowi = dgDepartamentos.CurrentRow.Index;
            string valor = dgDepartamentos[0, rowi].Value.ToString();
            idedit = Convert.ToInt32(valor);

            frmEditarDepartamento frmEditDep = new frmEditarDepartamento();
            frmEditDep._ideditar = idedit;
            frmEditDep.Show();
        }
    }
}

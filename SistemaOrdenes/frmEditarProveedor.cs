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
    public partial class frmEditarProveedor : Form
    {
        public int _ideditar = 0;
        public frmEditarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {
            int ideditar = _ideditar;
            Conexion conectar = new Conexion();
            Proveedores proveedores = new Proveedores();

            proveedores.getProveedor(ideditar, conectar.con);
            if (proveedores.id != 0)
            {
                tbNombre.Text = proveedores.nombre;
                tbDireccion.Text = proveedores.direccion;
                tbRFC.Text = proveedores.rfc;
                tbTelefono.Text = proveedores.telefono;
            }
            else {
                System.Windows.Forms.MessageBox.Show("Proveedor Inexistente " + ideditar);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            Proveedores actProveedor = new Proveedores();
            actProveedor.id = _ideditar;
            actProveedor.nombre = tbNombre.Text;
            actProveedor.direccion = tbDireccion.Text;
            actProveedor.rfc = tbRFC.Text;
            actProveedor.telefono = tbTelefono.Text;

            actProveedor.updateProveedor(actProveedor, conectar.con);
            System.Windows.Forms.MessageBox.Show("Proveedor Actualizado");
        }

      
    }
}

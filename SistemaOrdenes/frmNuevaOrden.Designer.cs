namespace SistemaOrdenes
{
    partial class frmNuevaOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaOrden));
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SistemaDataSet = new SistemaOrdenes.BD_SistemaDataSet();
            this.proveedoresTableAdapter = new SistemaOrdenes.BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dgDetallesOrden = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaquina = new System.Windows.Forms.TextBox();
            this.tbProyecto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbObra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardarOrden = new System.Windows.Forms.Button();
            this.tbPIva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Orden";
            // 
            // tbOrden
            // 
            this.tbOrden.Location = new System.Drawing.Point(84, 38);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(89, 20);
            this.tbOrden.TabIndex = 1;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(485, 9);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(97, 20);
            this.dtFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // cbProveedores
            // 
            this.cbProveedores.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedoresBindingSource, "nombre", true));
            this.cbProveedores.DataSource = this.proveedoresBindingSource;
            this.cbProveedores.DisplayMember = "nombre";
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(84, 6);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(327, 21);
            this.cbProveedores.TabIndex = 4;
            this.cbProveedores.ValueMember = "rfc";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.bD_SistemaDataSet;
            // 
            // bD_SistemaDataSet
            // 
            this.bD_SistemaDataSet.DataSetName = "BD_SistemaDataSet";
            this.bD_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proveedor";
            // 
            // dgDetallesOrden
            // 
            this.dgDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.punitario,
            this.costo});
            this.dgDetallesOrden.Location = new System.Drawing.Point(12, 81);
            this.dgDetallesOrden.Name = "dgDetallesOrden";
            this.dgDetallesOrden.Size = new System.Drawing.Size(570, 290);
            this.dgDetallesOrden.TabIndex = 6;
            this.dgDetallesOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // punitario
            // 
            this.punitario.Frozen = true;
            this.punitario.HeaderText = "P.Unitario";
            this.punitario.Name = "punitario";
            // 
            // costo
            // 
            this.costo.Frozen = true;
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SubTotal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "IVA %";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(486, 413);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(99, 20);
            this.tbSubTotal.TabIndex = 10;
            this.tbSubTotal.Text = "0.0";
            // 
            // tbIva
            // 
            this.tbIva.Location = new System.Drawing.Point(486, 441);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(100, 20);
            this.tbIva.TabIndex = 11;
            this.tbIva.Text = "0.0";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(485, 467);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 12;
            this.tbTotal.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Departamento";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(15, 407);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(139, 20);
            this.tbDepartamento.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vehiculo";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Items.AddRange(new object[] {
            "Vehiculo Uno",
            "Vehiculo Dos",
            "Vehiculo Tres"});
            this.cbVehiculo.Location = new System.Drawing.Point(15, 452);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(139, 21);
            this.cbVehiculo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Maquina";
            // 
            // tbUnidad
            // 
            this.tbUnidad.Location = new System.Drawing.Point(179, 407);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(139, 20);
            this.tbUnidad.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Unidad";
            // 
            // tbMaquina
            // 
            this.tbMaquina.Location = new System.Drawing.Point(179, 453);
            this.tbMaquina.Name = "tbMaquina";
            this.tbMaquina.Size = new System.Drawing.Size(139, 20);
            this.tbMaquina.TabIndex = 20;
            // 
            // tbProyecto
            // 
            this.tbProyecto.Location = new System.Drawing.Point(179, 493);
            this.tbProyecto.Name = "tbProyecto";
            this.tbProyecto.Size = new System.Drawing.Size(139, 20);
            this.tbProyecto.TabIndex = 24;
            this.tbProyecto.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Proyecto";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbObra
            // 
            this.tbObra.Location = new System.Drawing.Point(15, 493);
            this.tbObra.Name = "tbObra";
            this.tbObra.Size = new System.Drawing.Size(139, 20);
            this.tbObra.TabIndex = 22;
            this.tbObra.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Obra";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(510, 493);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(72, 25);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGuardarOrden
            // 
            this.btGuardarOrden.Location = new System.Drawing.Point(492, 47);
            this.btGuardarOrden.Name = "btGuardarOrden";
            this.btGuardarOrden.Size = new System.Drawing.Size(85, 25);
            this.btGuardarOrden.TabIndex = 26;
            this.btGuardarOrden.Text = "Generar Orden";
            this.btGuardarOrden.UseVisualStyleBackColor = true;
            // 
            // tbPIva
            // 
            this.tbPIva.Location = new System.Drawing.Point(438, 441);
            this.tbPIva.Name = "tbPIva";
            this.tbPIva.Size = new System.Drawing.Size(34, 20);
            this.tbPIva.TabIndex = 27;
            this.tbPIva.Text = "11";
            // 
            // frmNuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 530);
            this.Controls.Add(this.tbPIva);
            this.Controls.Add(this.btGuardarOrden);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbProyecto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbObra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbMaquina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUnidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbIva);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgDetallesOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tbOrden);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaOrden";
            this.Text = "Nueva Orden";
            this.Load += new System.EventHandler(this.frmNuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProveedores;
        private BD_SistemaDataSet bD_SistemaDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgDetallesOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn punitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMaquina;
        private System.Windows.Forms.TextBox tbProyecto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbObra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardarOrden;
        private System.Windows.Forms.TextBox tbPIva;
    }
}
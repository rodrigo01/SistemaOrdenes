namespace SistemaOrdenes
{
    partial class frmVerOrden
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
            this.btGuardarOrden = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbProyecto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbObra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaquina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgDetallesOrden = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPIva = new System.Windows.Forms.TextBox();
            this.btImprimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardarOrden
            // 
            this.btGuardarOrden.Location = new System.Drawing.Point(497, 65);
            this.btGuardarOrden.Name = "btGuardarOrden";
            this.btGuardarOrden.Size = new System.Drawing.Size(85, 25);
            this.btGuardarOrden.TabIndex = 54;
            this.btGuardarOrden.Text = "Guardar Orden";
            this.btGuardarOrden.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(520, 518);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(72, 25);
            this.btCancelar.TabIndex = 53;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // tbProyecto
            // 
            this.tbProyecto.Location = new System.Drawing.Point(179, 508);
            this.tbProyecto.Name = "tbProyecto";
            this.tbProyecto.Size = new System.Drawing.Size(139, 20);
            this.tbProyecto.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Proyecto";
            // 
            // tbObra
            // 
            this.tbObra.Location = new System.Drawing.Point(15, 508);
            this.tbObra.Name = "tbObra";
            this.tbObra.Size = new System.Drawing.Size(139, 20);
            this.tbObra.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Obra";
            // 
            // tbMaquina
            // 
            this.tbMaquina.Location = new System.Drawing.Point(179, 468);
            this.tbMaquina.Name = "tbMaquina";
            this.tbMaquina.Size = new System.Drawing.Size(139, 20);
            this.tbMaquina.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Maquina";
            // 
            // tbUnidad
            // 
            this.tbUnidad.Location = new System.Drawing.Point(179, 422);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(139, 20);
            this.tbUnidad.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Unidad";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Items.AddRange(new object[] {
            "Vehiculo Uno",
            "Vehiculo Dos",
            "Vehiculo Tres"});
            this.cbVehiculo.Location = new System.Drawing.Point(15, 467);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(139, 21);
            this.cbVehiculo.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Vehiculo";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(15, 422);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(139, 20);
            this.tbDepartamento.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Departamento";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(485, 482);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 40;
            this.tbTotal.Text = "0.0";
            // 
            // tbIva
            // 
            this.tbIva.Location = new System.Drawing.Point(486, 456);
            this.tbIva.Name = "tbIva";
            this.tbIva.ReadOnly = true;
            this.tbIva.Size = new System.Drawing.Size(100, 20);
            this.tbIva.TabIndex = 39;
            this.tbIva.Text = "0.0";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(486, 428);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(99, 20);
            this.tbSubTotal.TabIndex = 38;
            this.tbSubTotal.Tag = "";
            this.tbSubTotal.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "% IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "SubTotal";
            // 
            // dgDetallesOrden
            // 
            this.dgDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesOrden.Location = new System.Drawing.Point(12, 96);
            this.dgDetallesOrden.Name = "dgDetallesOrden";
            this.dgDetallesOrden.Size = new System.Drawing.Size(570, 290);
            this.dgDetallesOrden.TabIndex = 34;
            this.dgDetallesOrden.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallesOrden_CellEndEdit);
            this.dgDetallesOrden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallesOrden_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedores
            // 
            this.cbProveedores.DisplayMember = "nombre";
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(84, 21);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(327, 21);
            this.cbProveedores.TabIndex = 32;
            this.cbProveedores.ValueMember = "Id";
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(485, 24);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(97, 20);
            this.dtFecha.TabIndex = 30;
            // 
            // tbOrden
            // 
            this.tbOrden.Location = new System.Drawing.Point(84, 53);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(89, 20);
            this.tbOrden.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Num Orden";
            // 
            // tbPIva
            // 
            this.tbPIva.Location = new System.Drawing.Point(386, 453);
            this.tbPIva.Name = "tbPIva";
            this.tbPIva.Size = new System.Drawing.Size(31, 20);
            this.tbPIva.TabIndex = 55;
            this.tbPIva.Text = "11";
            this.tbPIva.TextChanged += new System.EventHandler(this.tbPIva_TextChanged);
            // 
            // btImprimi
            // 
            this.btImprimi.Location = new System.Drawing.Point(386, 65);
            this.btImprimi.Name = "btImprimi";
            this.btImprimi.Size = new System.Drawing.Size(91, 24);
            this.btImprimi.TabIndex = 56;
            this.btImprimi.Text = "Imprimir Orden";
            this.btImprimi.UseVisualStyleBackColor = true;
            // 
            // frmVerOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 555);
            this.Controls.Add(this.btImprimi);
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
            this.Name = "frmVerOrden";
            this.Text = "frmVerOrden";
            this.Load += new System.EventHandler(this.frmVerOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardarOrden;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbProyecto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbObra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaquina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgDetallesOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPIva;
        private System.Windows.Forms.Button btImprimi;
    }
}
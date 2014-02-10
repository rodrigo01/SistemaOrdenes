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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerOrden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btGuardarOrden = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbAlmacen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbObra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.tbUso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMaquina = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardarOrden
            // 
            this.btGuardarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btGuardarOrden.Image")));
            this.btGuardarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardarOrden.Location = new System.Drawing.Point(676, 537);
            this.btGuardarOrden.Name = "btGuardarOrden";
            this.btGuardarOrden.Size = new System.Drawing.Size(117, 34);
            this.btGuardarOrden.TabIndex = 54;
            this.btGuardarOrden.Text = "Guardar Orden";
            this.btGuardarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardarOrden.UseVisualStyleBackColor = true;
            this.btGuardarOrden.Click += new System.EventHandler(this.btGuardarOrden_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(576, 536);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 34);
            this.btCancelar.TabIndex = 53;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbAlmacen
            // 
            this.tbAlmacen.Location = new System.Drawing.Point(336, 536);
            this.tbAlmacen.Name = "tbAlmacen";
            this.tbAlmacen.Size = new System.Drawing.Size(139, 20);
            this.tbAlmacen.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Almacen";
            // 
            // tbObra
            // 
            this.tbObra.Location = new System.Drawing.Point(336, 491);
            this.tbObra.Name = "tbObra";
            this.tbObra.Size = new System.Drawing.Size(139, 20);
            this.tbObra.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(333, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Obra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Maquina";
            // 
            // tbUnidad
            // 
            this.tbUnidad.Location = new System.Drawing.Point(179, 491);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(139, 20);
            this.tbUnidad.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
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
            this.cbVehiculo.Location = new System.Drawing.Point(15, 536);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(139, 21);
            this.cbVehiculo.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Vehiculo";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(15, 491);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(139, 20);
            this.tbDepartamento.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Departamento";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(692, 493);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 40;
            this.tbTotal.Text = "0.0";
            // 
            // tbIva
            // 
            this.tbIva.Location = new System.Drawing.Point(693, 467);
            this.tbIva.Name = "tbIva";
            this.tbIva.ReadOnly = true;
            this.tbIva.Size = new System.Drawing.Size(100, 20);
            this.tbIva.TabIndex = 39;
            this.tbIva.Text = "0.0";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(693, 439);
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
            this.label6.Location = new System.Drawing.Point(642, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "% IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "SubTotal";
            // 
            // dgDetallesOrden
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallesOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetallesOrden.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDetallesOrden.Location = new System.Drawing.Point(12, 81);
            this.dgDetallesOrden.Name = "dgDetallesOrden";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallesOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDetallesOrden.Size = new System.Drawing.Size(781, 339);
            this.dgDetallesOrden.TabIndex = 34;
            this.dgDetallesOrden.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallesOrden_CellEndEdit);
            this.dgDetallesOrden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallesOrden_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(99, 21);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(327, 21);
            this.cbProveedores.TabIndex = 32;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(678, 52);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 30;
            // 
            // tbOrden
            // 
            this.tbOrden.Location = new System.Drawing.Point(693, 20);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(89, 20);
            this.tbOrden.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Num Orden";
            // 
            // tbPIva
            // 
            this.tbPIva.Location = new System.Drawing.Point(593, 464);
            this.tbPIva.Name = "tbPIva";
            this.tbPIva.Size = new System.Drawing.Size(31, 20);
            this.tbPIva.TabIndex = 55;
            this.tbPIva.Text = "11";
            this.tbPIva.TextChanged += new System.EventHandler(this.tbPIva_TextChanged);
            // 
            // btImprimi
            // 
            this.btImprimi.Image = ((System.Drawing.Image)(resources.GetObject("btImprimi.Image")));
            this.btImprimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimi.Location = new System.Drawing.Point(460, 24);
            this.btImprimi.Name = "btImprimi";
            this.btImprimi.Size = new System.Drawing.Size(114, 34);
            this.btImprimi.TabIndex = 56;
            this.btImprimi.Text = "Imprimir Orden";
            this.btImprimi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimi.UseVisualStyleBackColor = true;
            this.btImprimi.Click += new System.EventHandler(this.btImprimi_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 57;
            this.label13.Text = "Detalles Orden";
            // 
            // tbUso
            // 
            this.tbUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUso.Location = new System.Drawing.Point(15, 442);
            this.tbUso.Name = "tbUso";
            this.tbUso.Size = new System.Drawing.Size(460, 22);
            this.tbUso.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 426);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Para uso en";
            // 
            // cbMaquina
            // 
            this.cbMaquina.FormattingEnabled = true;
            this.cbMaquina.Location = new System.Drawing.Point(179, 535);
            this.cbMaquina.Name = "cbMaquina";
            this.cbMaquina.Size = new System.Drawing.Size(139, 21);
            this.cbMaquina.TabIndex = 93;
            // 
            // frmVerOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 583);
            this.Controls.Add(this.cbMaquina);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbUso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btImprimi);
            this.Controls.Add(this.tbPIva);
            this.Controls.Add(this.btGuardarOrden);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbAlmacen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbObra);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.TextBox tbAlmacen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbObra;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMaquina;
    }
}
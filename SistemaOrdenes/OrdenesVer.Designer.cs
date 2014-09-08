namespace SistemaOrdenes
{
    partial class OrdenesVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesVer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBPor = new System.Windows.Forms.ComboBox();
            this.tbValorB = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgOrdenes = new System.Windows.Forms.DataGridView();
            this.btDetalles = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btReporte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFinal);
            this.groupBox1.Controls.Add(this.dtInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBPor);
            this.groupBox1.Controls.Add(this.tbValorB);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(127, 65);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(107, 20);
            this.dtFinal.TabIndex = 11;
            this.dtFinal.Value = new System.DateTime(2014, 1, 16, 9, 59, 49, 0);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(6, 65);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(103, 20);
            this.dtInicial.TabIndex = 10;
            this.dtInicial.Value = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha inicial";
            // 
            // cbBPor
            // 
            this.cbBPor.FormattingEnabled = true;
            this.cbBPor.Items.AddRange(new object[] {
            "Orden",
            "Proveedor",
            "Departamento",
            "Vehiculo",
            "Almacen",
            "Maquina"});
            this.cbBPor.Location = new System.Drawing.Point(6, 19);
            this.cbBPor.Name = "cbBPor";
            this.cbBPor.Size = new System.Drawing.Size(121, 21);
            this.cbBPor.TabIndex = 3;
            // 
            // tbValorB
            // 
            this.tbValorB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbValorB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbValorB.Location = new System.Drawing.Point(147, 19);
            this.tbValorB.Name = "tbValorB";
            this.tbValorB.Size = new System.Drawing.Size(242, 20);
            this.tbValorB.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(303, 53);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(86, 37);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgOrdenes
            // 
            this.dgOrdenes.AllowUserToAddRows = false;
            this.dgOrdenes.AllowUserToDeleteRows = false;
            this.dgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenes.Location = new System.Drawing.Point(12, 114);
            this.dgOrdenes.Name = "dgOrdenes";
            this.dgOrdenes.ReadOnly = true;
            this.dgOrdenes.Size = new System.Drawing.Size(926, 452);
            this.dgOrdenes.TabIndex = 4;
            this.dgOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdenes_CellContentClick);
            // 
            // btDetalles
            // 
            this.btDetalles.Image = ((System.Drawing.Image)(resources.GetObject("btDetalles.Image")));
            this.btDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDetalles.Location = new System.Drawing.Point(820, 60);
            this.btDetalles.Name = "btDetalles";
            this.btDetalles.Size = new System.Drawing.Size(119, 37);
            this.btDetalles.TabIndex = 6;
            this.btDetalles.Text = "Detalles Orden";
            this.btDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDetalles.UseVisualStyleBackColor = true;
            this.btDetalles.Click += new System.EventHandler(this.btDetalles_Click);
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(569, 12);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(119, 35);
            this.btTodos.TabIndex = 7;
            this.btTodos.Text = "Ver Todas";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btReporte
            // 
            this.btReporte.Location = new System.Drawing.Point(820, 12);
            this.btReporte.Name = "btReporte";
            this.btReporte.Size = new System.Drawing.Size(118, 35);
            this.btReporte.TabIndex = 8;
            this.btReporte.Text = "Reporte Ordenes";
            this.btReporte.UseVisualStyleBackColor = true;
            this.btReporte.Click += new System.EventHandler(this.btReporte_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar Orden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrdenesVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btReporte);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btDetalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgOrdenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdenesVer";
            this.Text = "OrdenesVer";
            this.Activated += new System.EventHandler(this.OrdenesVer_Activated);
            this.Load += new System.EventHandler(this.OrdenesVer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBPor;
        private System.Windows.Forms.TextBox tbValorB;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgOrdenes;
        private System.Windows.Forms.Button btDetalles;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btReporte;
        private System.Windows.Forms.Button button1;
    }
}
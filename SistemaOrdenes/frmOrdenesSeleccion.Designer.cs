namespace SistemaOrdenes
{
    partial class frmOrdenesSeleccion
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.btnGenerarM = new System.Windows.Forms.Button();
            this.chbTodosM = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaquina = new System.Windows.Forms.ComboBox();
            this.btnGenerarV = new System.Windows.Forms.Button();
            this.chbTodosV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedores
            // 
            this.cbProveedores.DisplayMember = "nombre";
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(109, 33);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(327, 21);
            this.cbProveedores.TabIndex = 66;
            this.cbProveedores.ValueMember = "Id";
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(471, 27);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(117, 30);
            this.btGenerar.TabIndex = 68;
            this.btGenerar.Text = "Generar Reporte";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btnGenerarM
            // 
            this.btnGenerarM.Location = new System.Drawing.Point(346, 143);
            this.btnGenerarM.Name = "btnGenerarM";
            this.btnGenerarM.Size = new System.Drawing.Size(117, 30);
            this.btnGenerarM.TabIndex = 88;
            this.btnGenerarM.Text = "Generar Reporte";
            this.btnGenerarM.UseVisualStyleBackColor = true;
            this.btnGenerarM.Click += new System.EventHandler(this.btnGenerarM_Click);
            // 
            // chbTodosM
            // 
            this.chbTodosM.AutoSize = true;
            this.chbTodosM.Location = new System.Drawing.Point(183, 149);
            this.chbTodosM.Name = "chbTodosM";
            this.chbTodosM.Size = new System.Drawing.Size(135, 17);
            this.chbTodosM.TabIndex = 87;
            this.chbTodosM.Text = "Todos los Proveedores";
            this.chbTodosM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Maquinas";
            // 
            // cbMaquina
            // 
            this.cbMaquina.DisplayMember = "nombre";
            this.cbMaquina.FormattingEnabled = true;
            this.cbMaquina.Location = new System.Drawing.Point(25, 149);
            this.cbMaquina.Name = "cbMaquina";
            this.cbMaquina.Size = new System.Drawing.Size(138, 21);
            this.cbMaquina.TabIndex = 85;
            this.cbMaquina.ValueMember = "Id";
            // 
            // btnGenerarV
            // 
            this.btnGenerarV.Location = new System.Drawing.Point(346, 91);
            this.btnGenerarV.Name = "btnGenerarV";
            this.btnGenerarV.Size = new System.Drawing.Size(117, 30);
            this.btnGenerarV.TabIndex = 84;
            this.btnGenerarV.Text = "Generar Reporte";
            this.btnGenerarV.UseVisualStyleBackColor = true;
            this.btnGenerarV.Click += new System.EventHandler(this.button2_Click);
            // 
            // chbTodosV
            // 
            this.chbTodosV.AutoSize = true;
            this.chbTodosV.Location = new System.Drawing.Point(183, 97);
            this.chbTodosV.Name = "chbTodosV";
            this.chbTodosV.Size = new System.Drawing.Size(135, 17);
            this.chbTodosV.TabIndex = 83;
            this.chbTodosV.Text = "Todos los Proveedores";
            this.chbTodosV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Vehiculos";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DisplayMember = "nombre";
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(25, 97);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(138, 21);
            this.cbVehiculo.TabIndex = 81;
            this.cbVehiculo.ValueMember = "Id";
            // 
            // frmOrdenesSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 205);
            this.Controls.Add(this.btnGenerarM);
            this.Controls.Add(this.chbTodosM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaquina);
            this.Controls.Add(this.btnGenerarV);
            this.Controls.Add(this.chbTodosV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProveedores);
            this.Name = "frmOrdenesSeleccion";
            this.Text = "Reporte Ordenes";
            this.Load += new System.EventHandler(this.frmOrdenesSeleccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btnGenerarM;
        private System.Windows.Forms.CheckBox chbTodosM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaquina;
        private System.Windows.Forms.Button btnGenerarV;
        private System.Windows.Forms.CheckBox chbTodosV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVehiculo;
    }
}
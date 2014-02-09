namespace SistemaOrdenes
{
    partial class frmNuevoVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoVehiculo));
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoEconomico = new System.Windows.Forms.TextBox();
            this.btGuardarOrden = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 104;
            this.label7.Text = "Usario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(143, 172);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(159, 20);
            this.tbUsuario.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "Clase";
            // 
            // tbClase
            // 
            this.tbClase.Location = new System.Drawing.Point(16, 172);
            this.tbClase.Margin = new System.Windows.Forms.Padding(4);
            this.tbClase.Name = "tbClase";
            this.tbClase.Size = new System.Drawing.Size(104, 20);
            this.tbClase.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(410, 42);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(128, 20);
            this.tbModelo.TabIndex = 99;
            this.tbModelo.TextChanged += new System.EventHandler(this.tbModelo_TextChanged);
            this.tbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbModelo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(246, 109);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(292, 20);
            this.tbTipo.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "Linea";
            // 
            // tbLinea
            // 
            this.tbLinea.Location = new System.Drawing.Point(16, 109);
            this.tbLinea.Margin = new System.Windows.Forms.Padding(4);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.Size = new System.Drawing.Size(209, 20);
            this.tbLinea.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(246, 42);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(141, 20);
            this.tbMarca.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "NoEconomico";
            // 
            // tbNoEconomico
            // 
            this.tbNoEconomico.Location = new System.Drawing.Point(16, 42);
            this.tbNoEconomico.Margin = new System.Windows.Forms.Padding(4);
            this.tbNoEconomico.Name = "tbNoEconomico";
            this.tbNoEconomico.Size = new System.Drawing.Size(209, 20);
            this.tbNoEconomico.TabIndex = 91;
            // 
            // btGuardarOrden
            // 
            this.btGuardarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btGuardarOrden.Image")));
            this.btGuardarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardarOrden.Location = new System.Drawing.Point(350, 160);
            this.btGuardarOrden.Name = "btGuardarOrden";
            this.btGuardarOrden.Size = new System.Drawing.Size(126, 34);
            this.btGuardarOrden.TabIndex = 106;
            this.btGuardarOrden.Text = "Guardar Vehiculo";
            this.btGuardarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardarOrden.UseVisualStyleBackColor = true;
            this.btGuardarOrden.Click += new System.EventHandler(this.btGuardarOrden_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(482, 160);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(94, 34);
            this.btCancelar.TabIndex = 105;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 216);
            this.Controls.Add(this.btGuardarOrden);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbClase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoEconomico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoVehiculo";
            this.Text = "Vehiculo Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardarOrden;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoEconomico;
    }
}
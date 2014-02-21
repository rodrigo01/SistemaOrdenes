namespace SistemaOrdenes
{
    partial class frmReporteVehiculos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VehiculosDS = new SistemaOrdenes.VehiculosDS();
            this.VehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehiculosTableAdapter = new SistemaOrdenes.VehiculosDSTableAdapters.VehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Vehiculos";
            reportDataSource1.Value = this.VehiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaOrdenes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(738, 640);
            this.reportViewer1.TabIndex = 0;
            // 
            // VehiculosDS
            // 
            this.VehiculosDS.DataSetName = "VehiculosDS";
            this.VehiculosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VehiculosBindingSource
            // 
            this.VehiculosBindingSource.DataMember = "Vehiculos";
            this.VehiculosBindingSource.DataSource = this.VehiculosDS;
            // 
            // VehiculosTableAdapter
            // 
            this.VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteVehiculos";
            this.Text = "frmReporteVehiculos";
            this.Load += new System.EventHandler(this.frmReporteVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VehiculosBindingSource;
        private VehiculosDS VehiculosDS;
        private VehiculosDSTableAdapters.VehiculosTableAdapter VehiculosTableAdapter;
    }
}
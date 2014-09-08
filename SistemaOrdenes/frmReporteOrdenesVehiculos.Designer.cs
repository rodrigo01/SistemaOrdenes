namespace SistemaOrdenes
{
    partial class frmReporteOrdenesVehiculos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_SistemaDataSet2 = new SistemaOrdenes.BD_SistemaDataSet2();
            this.ProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedoresTableAdapter = new SistemaOrdenes.BD_SistemaDataSet2TableAdapters.ProveedoresTableAdapter();
            this.ConReRS = new SistemaOrdenes.ConReRS();
            this.ConReporteTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConReporteTablaTableAdapter = new SistemaOrdenes.ConReRSTableAdapters.ConReporteTablaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SistemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConReRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConReporteTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Proveedor";
            reportDataSource1.Value = this.ProveedoresBindingSource;
            reportDataSource2.Name = "ConReporteTabla";
            reportDataSource2.Value = this.ConReporteTablaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaOrdenes.Report4Vehic.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_SistemaDataSet2
            // 
            this.BD_SistemaDataSet2.DataSetName = "BD_SistemaDataSet2";
            this.BD_SistemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProveedoresBindingSource
            // 
            this.ProveedoresBindingSource.DataMember = "Proveedores";
            this.ProveedoresBindingSource.DataSource = this.BD_SistemaDataSet2;
            // 
            // ProveedoresTableAdapter
            // 
            this.ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ConReRS
            // 
            this.ConReRS.DataSetName = "ConReRS";
            this.ConReRS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConReporteTablaBindingSource
            // 
            this.ConReporteTablaBindingSource.DataMember = "ConReporteTabla";
            this.ConReporteTablaBindingSource.DataSource = this.ConReRS;
            // 
            // ConReporteTablaTableAdapter
            // 
            this.ConReporteTablaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteOrdenesVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteOrdenesVehiculos";
            this.Text = "Reporte Ordenes Vehiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_SistemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConReRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConReporteTablaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProveedoresBindingSource;
        private BD_SistemaDataSet2 BD_SistemaDataSet2;
        private System.Windows.Forms.BindingSource ConReporteTablaBindingSource;
        private ConReRS ConReRS;
        private BD_SistemaDataSet2TableAdapters.ProveedoresTableAdapter ProveedoresTableAdapter;
        private ConReRSTableAdapters.ConReporteTablaTableAdapter ConReporteTablaTableAdapter;
    }
}
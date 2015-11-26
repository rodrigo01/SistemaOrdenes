namespace SistemaOrdenes
{
    partial class ImprimirOrden
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirOrden));
            this.OrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteP = new SistemaOrdenes.ReporteP();
            this.Detalles_OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_SistemaDataSet2 = new SistemaOrdenes.BD_SistemaDataSet2();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SistemaDataSet = new SistemaOrdenes.BD_SistemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proveedoresTableAdapter = new SistemaOrdenes.BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter();
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenesTableAdapter = new SistemaOrdenes.ReportePTableAdapters.OrdenesTableAdapter();
            this.Detalles_OrdenTableAdapter = new SistemaOrdenes.BD_SistemaDataSet2TableAdapters.Detalles_OrdenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SistemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenesBindingSource
            // 
            this.OrdenesBindingSource.DataMember = "Ordenes";
            this.OrdenesBindingSource.DataSource = this.ReporteP;
            // 
            // ReporteP
            // 
            this.ReporteP.DataSetName = "ReporteP";
            this.ReporteP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Detalles_OrdenBindingSource
            // 
            this.Detalles_OrdenBindingSource.DataMember = "Detalles_Orden";
            this.Detalles_OrdenBindingSource.DataSource = this.BD_SistemaDataSet2;
            // 
            // BD_SistemaDataSet2
            // 
            this.BD_SistemaDataSet2.DataSetName = "BD_SistemaDataSet2";
            this.BD_SistemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrdenInfo";
            reportDataSource1.Value = this.OrdenesBindingSource;
            reportDataSource2.Name = "Detalles";
            reportDataSource2.Value = this.Detalles_OrdenBindingSource;
            reportDataSource3.Name = "Proveedor";
            reportDataSource3.Value = this.proveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaOrdenes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 506);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataMember = "Proveedores";
            this.proveedoresBindingSource1.DataSource = this.bD_SistemaDataSet;
            // 
            // OrdenesTableAdapter
            // 
            this.OrdenesTableAdapter.ClearBeforeFill = true;
            // 
            // Detalles_OrdenTableAdapter
            // 
            this.Detalles_OrdenTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimirOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImprimirOrden";
            this.Text = "Orden a Imprimir";
            this.Load += new System.EventHandler(this.ImprimirOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SistemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_SistemaDataSet bD_SistemaDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.BindingSource proveedoresBindingSource1;
        private System.Windows.Forms.BindingSource OrdenesBindingSource;
        private ReporteP ReporteP;
        private System.Windows.Forms.BindingSource Detalles_OrdenBindingSource;
        private BD_SistemaDataSet2 BD_SistemaDataSet2;
        private ReportePTableAdapters.OrdenesTableAdapter OrdenesTableAdapter;
        private BD_SistemaDataSet2TableAdapters.Detalles_OrdenTableAdapter Detalles_OrdenTableAdapter;

    }
}
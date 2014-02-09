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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirOrden));
            this.Detalles_OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteP = new SistemaOrdenes.ReporteP();
            this.OrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSistemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SistemaDataSet = new SistemaOrdenes.BD_SistemaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalles_OrdenTableAdapter = new SistemaOrdenes.ReportePTableAdapters.Detalles_OrdenTableAdapter();
            this.proveedoresTableAdapter = new SistemaOrdenes.BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter();
            this.tbbid = new SistemaOrdenes.tbbid();
            this.tbbidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenesTableAdapter = new SistemaOrdenes.ReportePTableAdapters.OrdenesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSistemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalles_OrdenBindingSource
            // 
            this.Detalles_OrdenBindingSource.DataMember = "Detalles_Orden";
            this.Detalles_OrdenBindingSource.DataSource = this.ReporteP;
            // 
            // ReporteP
            // 
            this.ReporteP.DataSetName = "ReporteP";
            this.ReporteP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdenesBindingSource
            // 
            this.OrdenesBindingSource.DataMember = "Ordenes";
            this.OrdenesBindingSource.DataSource = this.ReporteP;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.bDSistemaDataSetBindingSource;
            // 
            // bDSistemaDataSetBindingSource
            // 
            this.bDSistemaDataSetBindingSource.DataSource = this.bD_SistemaDataSet;
            this.bDSistemaDataSetBindingSource.Position = 0;
            // 
            // bD_SistemaDataSet
            // 
            this.bD_SistemaDataSet.DataSetName = "BD_SistemaDataSet";
            this.bD_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Detalles_OrdenBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.OrdenesBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.proveedoresBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.OrdenesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaOrdenes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // Detalles_OrdenTableAdapter
            // 
            this.Detalles_OrdenTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tbbid
            // 
            this.tbbid.DataSetName = "tbbid";
            this.tbbid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbbidBindingSource
            // 
            this.tbbidBindingSource.DataSource = this.tbbid;
            this.tbbidBindingSource.Position = 0;
            // 
            // OrdenesTableAdapter
            // 
            this.OrdenesTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimirOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImprimirOrden";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ImprimirOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSistemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbidBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Detalles_OrdenBindingSource;
        private ReporteP ReporteP;
        private ReportePTableAdapters.Detalles_OrdenTableAdapter Detalles_OrdenTableAdapter;
        private BD_SistemaDataSet bD_SistemaDataSet;
        private System.Windows.Forms.BindingSource bDSistemaDataSetBindingSource;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private BD_SistemaDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.BindingSource tbbidBindingSource;
        private tbbid tbbid;
        private System.Windows.Forms.BindingSource OrdenesBindingSource;
        private ReportePTableAdapters.OrdenesTableAdapter OrdenesTableAdapter;

    }
}
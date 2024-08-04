namespace mystore.Forms
{
    partial class impmed
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
            this.medicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dsmed = new mystore.Forms.Dsmed();
            this.medicamentsTableAdapter = new mystore.Forms.DsmedTableAdapters.medicamentsTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new mystore.Forms.DsmedTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dsmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "mystore.Forms.medicament.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // medicamentsBindingSource
            // 
            this.medicamentsBindingSource.DataMember = "medicaments";
            this.medicamentsBindingSource.DataSource = this.Dsmed;
            // 
            // Dsmed
            // 
            this.Dsmed.DataSetName = "Dsmed";
            this.Dsmed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsTableAdapter
            // 
            this.medicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Dsmed;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // impmed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "impmed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "impmed";
            this.Load += new System.EventHandler(this.impmed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dsmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource medicamentsBindingSource;
        private Dsmed Dsmed;
        private DsmedTableAdapters.medicamentsTableAdapter medicamentsTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DsmedTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}
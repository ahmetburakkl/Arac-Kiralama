
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.araç_kıralamaDataSet = new WindowsFormsApp1.araç_kıralamaDataSet();
            this.araçbilgi2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araçbilgi2TableAdapter = new WindowsFormsApp1.araç_kıralamaDataSetTableAdapters.araçbilgi2TableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.musteribilgi2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteribilgi2TableAdapter = new WindowsFormsApp1.araç_kıralamaDataSetTableAdapters.musteribilgi2TableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sözlesmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sözlesmeTableAdapter = new WindowsFormsApp1.araç_kıralamaDataSetTableAdapters.sözlesmeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.araç_kıralamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araçbilgi2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilgi2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sözlesmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.araçbilgi2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ARAÇ.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1442, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // araç_kıralamaDataSet
            // 
            this.araç_kıralamaDataSet.DataSetName = "araç_kıralamaDataSet";
            this.araç_kıralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araçbilgi2BindingSource
            // 
            this.araçbilgi2BindingSource.DataMember = "araçbilgi2";
            this.araçbilgi2BindingSource.DataSource = this.araç_kıralamaDataSet;
            // 
            // araçbilgi2TableAdapter
            // 
            this.araçbilgi2TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.musteribilgi2BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.MÜŞTERİ.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 303);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1442, 287);
            this.reportViewer2.TabIndex = 1;
            // 
            // musteribilgi2BindingSource
            // 
            this.musteribilgi2BindingSource.DataMember = "musteribilgi2";
            this.musteribilgi2BindingSource.DataSource = this.araç_kıralamaDataSet;
            // 
            // musteribilgi2TableAdapter
            // 
            this.musteribilgi2TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.DocumentMapWidth = 35;
            reportDataSource3.Name = "MÜŞTERİ";
            reportDataSource3.Value = this.sözlesmeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 596);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1442, 305);
            this.reportViewer3.TabIndex = 2;
            // 
            // sözlesmeBindingSource
            // 
            this.sözlesmeBindingSource.DataMember = "sözlesme";
            this.sözlesmeBindingSource.DataSource = this.araç_kıralamaDataSet;
            // 
            // sözlesmeTableAdapter
            // 
            this.sözlesmeTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 905);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.araç_kıralamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araçbilgi2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilgi2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sözlesmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource araçbilgi2BindingSource;
        private araç_kıralamaDataSet araç_kıralamaDataSet;
        private araç_kıralamaDataSetTableAdapters.araçbilgi2TableAdapter araçbilgi2TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource musteribilgi2BindingSource;
        private araç_kıralamaDataSetTableAdapters.musteribilgi2TableAdapter musteribilgi2TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource sözlesmeBindingSource;
        private araç_kıralamaDataSetTableAdapters.sözlesmeTableAdapter sözlesmeTableAdapter;
    }
}
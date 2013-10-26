namespace ReportTesting
{
    partial class Form1
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
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ReportTesting.DataSet1();
            this.CustomersTableAdapter = new ReportTesting.DataSet1TableAdapters.CustomersTableAdapter();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Customer";
            reportDataSource1.Value = this.CustomersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportTesting.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(131, 156);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 398);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(183, 78);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.CustomersTableAdapter CustomersTableAdapter;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button button1;
    }
}


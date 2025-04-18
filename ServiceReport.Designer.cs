namespace FINAL_OOP
{
    partial class ServiceReport
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
            this.serviceReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.servicecombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearcomboboc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceReportTableAdapter = new FINAL_OOP.PrintingSystemDataSetTableAdapters.ServiceReportTableAdapter();
            this.serviceReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceReportViewBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet2 = new FINAL_OOP.PrintingSystemDataSet2();
            this.serviceReportViewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewTableAdapter = new FINAL_OOP.PrintingSystemDataSet2TableAdapters.ServiceReportViewTableAdapter();
            this.printingSystemDataSet4 = new FINAL_OOP.PrintingSystemDataSet4();
            this.viewServiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceReportBindingSource2
            // 
            this.serviceReportBindingSource2.DataMember = "ServiceReport";
            // 
            // serviceReportBindingSource1
            // 
            this.serviceReportBindingSource1.DataMember = "ServiceReport";
            // 
            // serviceReportBindingSource
            // 
            this.serviceReportBindingSource.DataMember = "ServiceReport";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(717, 514);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 39);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Location = new System.Drawing.Point(84, 512);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(168, 39);
            this.GenerateReportBtn.TabIndex = 15;
            this.GenerateReportBtn.Text = "Generate Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // servicecombobox
            // 
            this.servicecombobox.FormattingEnabled = true;
            this.servicecombobox.Items.AddRange(new object[] {
            "Printing A4 - Black and White",
            "Printing A4 - Color",
            "Binding - Comb Bining",
            "Binding - Thick Cover",
            "Printing - Poster (A0)",
            "Printing - Poster (A1)",
            "Printing - Poster (A2)",
            "Printing - Poster (A3)"});
            this.servicecombobox.Location = new System.Drawing.Point(690, 78);
            this.servicecombobox.Name = "servicecombobox";
            this.servicecombobox.Size = new System.Drawing.Size(188, 28);
            this.servicecombobox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Service :";
            // 
            // monthcombobox
            // 
            this.monthcombobox.FormattingEnabled = true;
            this.monthcombobox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthcombobox.Location = new System.Drawing.Point(385, 77);
            this.monthcombobox.Name = "monthcombobox";
            this.monthcombobox.Size = new System.Drawing.Size(188, 28);
            this.monthcombobox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Month :";
            // 
            // yearcomboboc
            // 
            this.yearcomboboc.FormattingEnabled = true;
            this.yearcomboboc.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.yearcomboboc.Location = new System.Drawing.Point(90, 74);
            this.yearcomboboc.Name = "yearcomboboc";
            this.yearcomboboc.Size = new System.Drawing.Size(188, 28);
            this.yearcomboboc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year :";
            // 
            // serviceReportTableAdapter
            // 
            this.serviceReportTableAdapter.ClearBeforeFill = true;
            // 
            // serviceReportViewBindingSource
            // 
            this.serviceReportViewBindingSource.DataMember = "ServiceReportView";
            // 
            // serviceReportViewBindingSource1
            // 
            this.serviceReportViewBindingSource1.DataMember = "ServiceReportView";
            // 
            // serviceReportViewBindingSource2
            // 
            this.serviceReportViewBindingSource2.DataMember = "ServiceReportView";
            // 
            // serviceReportViewBindingSource3
            // 
            this.serviceReportViewBindingSource3.DataMember = "ServiceReportView";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.viewServiceReportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(735, 274);
            this.dataGridView1.TabIndex = 17;
            // 
            // serviceReportViewBindingSource6
            // 
            this.serviceReportViewBindingSource6.DataMember = "ServiceReportView";
            this.serviceReportViewBindingSource6.DataSource = this.printingSystemDataSet2;
            // 
            // printingSystemDataSet2
            // 
            this.printingSystemDataSet2.DataSetName = "PrintingSystemDataSet2";
            this.printingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceReportViewBindingSource5
            // 
            this.serviceReportViewBindingSource5.DataMember = "ServiceReportView";
            // 
            // serviceReportViewBindingSource4
            // 
            this.serviceReportViewBindingSource4.DataMember = "ServiceReportView";
            // 
            // customerReportViewBindingSource
            // 
            this.customerReportViewBindingSource.DataMember = "CustomerReportView";
            // 
            // serviceReportViewTableAdapter
            // 
            this.serviceReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // printingSystemDataSet4
            // 
            this.printingSystemDataSet4.DataSetName = "PrintingSystemDataSet4";
            this.printingSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewServiceReportBindingSource
            // 
            this.viewServiceReportBindingSource.DataMember = "ViewServiceReport";
            this.viewServiceReportBindingSource.DataSource = this.printingSystemDataSet4;
            // 
            // viewServiceReportTableAdapter
            // 
            // 
            // ServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.servicecombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearcomboboc);
            this.Controls.Add(this.label1);
            this.Name = "ServiceReport";
            this.Text = "ServiceReport";
            this.Load += new System.EventHandler(this.ServiceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.ComboBox servicecombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearcomboboc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource serviceReportBindingSource;
        private System.Windows.Forms.BindingSource serviceReportBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceReportBindingSource2;
        private PrintingSystemDataSetTableAdapters.ServiceReportTableAdapter serviceReportTableAdapter;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource1;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource2;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource4;
        private System.Windows.Forms.BindingSource customerReportViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource5;
        private PrintingSystemDataSet2 printingSystemDataSet2;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource6;
        private PrintingSystemDataSet2TableAdapters.ServiceReportViewTableAdapter serviceReportViewTableAdapter;
        private PrintingSystemDataSet4 printingSystemDataSet4;
        private System.Windows.Forms.BindingSource viewServiceReportBindingSource;
    }
}
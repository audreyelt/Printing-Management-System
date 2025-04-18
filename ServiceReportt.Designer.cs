namespace FINAL_OOP
{
    partial class ServiceReportt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceReportt));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceReportViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet4 = new FINAL_OOP.PrintingSystemDataSet4();
            this.serviceReportViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet3 = new FINAL_OOP.PrintingSystemDataSet3();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.servicecombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearcomboboc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printingSystemDataSet2 = new FINAL_OOP.PrintingSystemDataSet2();
            this.serviceReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewTableAdapter = new FINAL_OOP.PrintingSystemDataSet2TableAdapters.ServiceReportViewTableAdapter();
            this.serviceReportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportViewTableAdapter1 = new FINAL_OOP.PrintingSystemDataSet3TableAdapters.ServiceReportViewTableAdapter();
            this.serviceReportViewTableAdapter2 = new FINAL_OOP.PrintingSystemDataSet4TableAdapters.ServiceReportViewTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTypeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceReportViewBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(605, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(735, 274);
            this.dataGridView1.TabIndex = 26;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "ServiceType";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 150;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceReportViewBindingSource3
            // 
            this.serviceReportViewBindingSource3.DataMember = "ServiceReportView";
            this.serviceReportViewBindingSource3.DataSource = this.printingSystemDataSet4;
            // 
            // printingSystemDataSet4
            // 
            this.printingSystemDataSet4.DataSetName = "PrintingSystemDataSet4";
            this.printingSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceReportViewBindingSource2
            // 
            this.serviceReportViewBindingSource2.DataMember = "ServiceReportView";
            this.serviceReportViewBindingSource2.DataSource = this.printingSystemDataSet3;
            // 
            // printingSystemDataSet3
            // 
            this.printingSystemDataSet3.DataSetName = "PrintingSystemDataSet3";
            this.printingSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.GenerateReportBtn.Location = new System.Drawing.Point(835, 683);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(284, 57);
            this.GenerateReportBtn.TabIndex = 24;
            this.GenerateReportBtn.Text = "Generate Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = true;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // servicecombobox
            // 
            this.servicecombobox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.servicecombobox.Location = new System.Drawing.Point(1205, 255);
            this.servicecombobox.Name = "servicecombobox";
            this.servicecombobox.Size = new System.Drawing.Size(188, 29);
            this.servicecombobox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1130, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Service :";
            // 
            // monthcombobox
            // 
            this.monthcombobox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.monthcombobox.Location = new System.Drawing.Point(900, 254);
            this.monthcombobox.Name = "monthcombobox";
            this.monthcombobox.Size = new System.Drawing.Size(188, 29);
            this.monthcombobox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Month :";
            // 
            // yearcomboboc
            // 
            this.yearcomboboc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearcomboboc.FormattingEnabled = true;
            this.yearcomboboc.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.yearcomboboc.Location = new System.Drawing.Point(605, 251);
            this.yearcomboboc.Name = "yearcomboboc";
            this.yearcomboboc.Size = new System.Drawing.Size(188, 29);
            this.yearcomboboc.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Year :";
            // 
            // printingSystemDataSet2
            // 
            this.printingSystemDataSet2.DataSetName = "PrintingSystemDataSet2";
            this.printingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceReportViewBindingSource
            // 
            this.serviceReportViewBindingSource.DataMember = "ServiceReportView";
            this.serviceReportViewBindingSource.DataSource = this.printingSystemDataSet2;
            // 
            // serviceReportViewTableAdapter
            // 
            this.serviceReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // serviceReportViewBindingSource1
            // 
            this.serviceReportViewBindingSource1.DataMember = "ServiceReportView";
            this.serviceReportViewBindingSource1.DataSource = this.printingSystemDataSet3;
            // 
            // serviceReportViewTableAdapter1
            // 
            this.serviceReportViewTableAdapter1.ClearBeforeFill = true;
            // 
            // serviceReportViewTableAdapter2
            // 
            this.serviceReportViewTableAdapter2.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(34, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 106);
            this.label4.TabIndex = 28;
            this.label4.Text = "Generate Service Report";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 831);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 72);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceReportt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.servicecombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearcomboboc);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ServiceReportt";
            this.Text = "ServiceReportt";
            this.Load += new System.EventHandler(this.ServiceReportt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportViewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.ComboBox servicecombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearcomboboc;
        private System.Windows.Forms.Label label1;
        private PrintingSystemDataSet2 printingSystemDataSet2;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource;
        private PrintingSystemDataSet2TableAdapters.ServiceReportViewTableAdapter serviceReportViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private PrintingSystemDataSet3 printingSystemDataSet3;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource1;
        private PrintingSystemDataSet3TableAdapters.ServiceReportViewTableAdapter serviceReportViewTableAdapter1;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource2;
        private PrintingSystemDataSet4 printingSystemDataSet4;
        private System.Windows.Forms.BindingSource serviceReportViewBindingSource3;
        private PrintingSystemDataSet4TableAdapters.ServiceReportViewTableAdapter serviceReportViewTableAdapter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
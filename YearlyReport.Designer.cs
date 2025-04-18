namespace FINAL_OOP
{
    partial class YearlyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlyReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet2 = new FINAL_OOP.PrintingSystemDataSet2();
            this.yearlyReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet = new FINAL_OOP.PrintingSystemDataSet();
            this.yearlyReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yearlyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearlyReportTableAdapter = new FINAL_OOP.PrintingSystemDataSetTableAdapters.YearlyReportTableAdapter();
            this.yearlyReportViewTableAdapter = new FINAL_OOP.PrintingSystemDataSet2TableAdapters.YearlyReportViewTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.yearlyReportViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(599, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(716, 272);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn1.HeaderText = "Year";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn2.HeaderText = "Month";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // yearlyReportViewBindingSource
            // 
            this.yearlyReportViewBindingSource.DataMember = "YearlyReportView";
            this.yearlyReportViewBindingSource.DataSource = this.printingSystemDataSet2;
            // 
            // printingSystemDataSet2
            // 
            this.printingSystemDataSet2.DataSetName = "PrintingSystemDataSet2";
            this.printingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yearlyReportBindingSource2
            // 
            this.yearlyReportBindingSource2.DataMember = "YearlyReport";
            this.yearlyReportBindingSource2.DataSource = this.printingSystemDataSet;
            // 
            // printingSystemDataSet
            // 
            this.printingSystemDataSet.DataSetName = "PrintingSystemDataSet";
            this.printingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yearlyReportBindingSource1
            // 
            this.yearlyReportBindingSource1.DataMember = "YearlyReport";
            // 
            // yearlyReportBindingSource
            // 
            this.yearlyReportBindingSource.DataMember = "YearlyReport";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(55, 825);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(325, 72);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.Location = new System.Drawing.Point(820, 664);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(259, 61);
            this.GenerateBtn.TabIndex = 13;
            this.GenerateBtn.Text = "Generate Report";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.comboBox1.Location = new System.Drawing.Point(687, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 29);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Year :";
            // 
            // yearlyReportTableAdapter
            // 
            this.yearlyReportTableAdapter.ClearBeforeFill = true;
            // 
            // yearlyReportViewTableAdapter
            // 
            this.yearlyReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 106);
            this.label2.TabIndex = 16;
            this.label2.Text = "Generate Yearly Report";
            // 
            // YearlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "YearlyReport";
            this.Text = "Yearly Report";
            this.Load += new System.EventHandler(this.YearlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource yearlyReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yearlyReportBindingSource1;
        private PrintingSystemDataSet printingSystemDataSet;
        private System.Windows.Forms.BindingSource yearlyReportBindingSource2;
        private PrintingSystemDataSetTableAdapters.YearlyReportTableAdapter yearlyReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private PrintingSystemDataSet2 printingSystemDataSet2;
        private System.Windows.Forms.BindingSource yearlyReportViewBindingSource;
        private PrintingSystemDataSet2TableAdapters.YearlyReportViewTableAdapter yearlyReportViewTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}


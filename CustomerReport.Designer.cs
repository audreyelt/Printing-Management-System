namespace FINAL_OOP
{
    partial class CustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.GenerateReportBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet2 = new FINAL_OOP.PrintingSystemDataSet2();
            this.customerReportBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet = new FINAL_OOP.PrintingSystemDataSet();
            this.customerReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monthcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportTableAdapter = new FINAL_OOP.PrintingSystemDataSetTableAdapters.CustomerReportTableAdapter();
            this.customerReportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportViewTableAdapter = new FINAL_OOP.PrintingSystemDataSet2TableAdapters.CustomerReportViewTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtbox.Location = new System.Drawing.Point(760, 319);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(272, 27);
            this.usernametxtbox.TabIndex = 17;
            // 
            // GenerateReportBtn
            // 
            this.GenerateReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateReportBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportBtn.Location = new System.Drawing.Point(822, 643);
            this.GenerateReportBtn.Name = "GenerateReportBtn";
            this.GenerateReportBtn.Size = new System.Drawing.Size(210, 57);
            this.GenerateReportBtn.TabIndex = 15;
            this.GenerateReportBtn.Text = "Generate Report";
            this.GenerateReportBtn.UseVisualStyleBackColor = false;
            this.GenerateReportBtn.Click += new System.EventHandler(this.GenerateReportBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.customerReportViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(526, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer_Username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ServiceType";
            this.dataGridViewTextBoxColumn2.HeaderText = "ServiceType";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn3.HeaderText = "Year";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn4.HeaderText = "Month";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // customerReportViewBindingSource
            // 
            this.customerReportViewBindingSource.DataMember = "CustomerReportView";
            this.customerReportViewBindingSource.DataSource = this.printingSystemDataSet2;
            // 
            // printingSystemDataSet2
            // 
            this.printingSystemDataSet2.DataSetName = "PrintingSystemDataSet2";
            this.printingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerReportBindingSource4
            // 
            this.customerReportBindingSource4.DataMember = "CustomerReport";
            this.customerReportBindingSource4.DataSource = this.printingSystemDataSet;
            // 
            // printingSystemDataSet
            // 
            this.printingSystemDataSet.DataSetName = "PrintingSystemDataSet";
            this.printingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerReportBindingSource2
            // 
            this.customerReportBindingSource2.DataMember = "CustomerReport";
            this.customerReportBindingSource2.DataSource = this.printingSystemDataSet;
            // 
            // customerReportBindingSource1
            // 
            this.customerReportBindingSource1.DataMember = "CustomerReport";
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
            this.monthcombobox.Location = new System.Drawing.Point(760, 264);
            this.monthcombobox.Name = "monthcombobox";
            this.monthcombobox.Size = new System.Drawing.Size(272, 29);
            this.monthcombobox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Month : ";
            // 
            // customerReportBindingSource
            // 
            this.customerReportBindingSource.DataMember = "CustomerReport";
            // 
            // customerReportTableAdapter
            // 
            this.customerReportTableAdapter.ClearBeforeFill = true;
            // 
            // customerReportBindingSource3
            // 
            this.customerReportBindingSource3.DataMember = "CustomerReport";
            this.customerReportBindingSource3.DataSource = this.printingSystemDataSet;
            // 
            // customerReportViewTableAdapter
            // 
            this.customerReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 174);
            this.label3.TabIndex = 19;
            this.label3.Text = "Generate Customer Report";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 824);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 72);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.GenerateReportBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Button GenerateReportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox monthcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource customerReportBindingSource;
        private System.Windows.Forms.BindingSource customerReportBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private PrintingSystemDataSet printingSystemDataSet;
        private System.Windows.Forms.BindingSource customerReportBindingSource2;
        private PrintingSystemDataSetTableAdapters.CustomerReportTableAdapter customerReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource customerReportBindingSource4;
        private System.Windows.Forms.BindingSource customerReportBindingSource3;
        private PrintingSystemDataSet2 printingSystemDataSet2;
        private System.Windows.Forms.BindingSource customerReportViewBindingSource;
        private PrintingSystemDataSet2TableAdapters.CustomerReportViewTableAdapter customerReportViewTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
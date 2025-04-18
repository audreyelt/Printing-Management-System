namespace FINAL_OOP
{
    partial class MakePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakePayment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRequestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentRequestDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet2 = new FINAL_OOP.PrintingSystemDataSet2();
            this.custReqTableAdapter = new FINAL_OOP.PrintingSystemDataSet2TableAdapters.CustReqTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custname = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.requestDateTimeDataGridViewTextBoxColumn,
            this.customerUsernameDataGridViewTextBoxColumn,
            this.itemRequestIDDataGridViewTextBoxColumn,
            this.serviceNoDataGridViewTextBoxColumn,
            this.quantityOrderedDataGridViewTextBoxColumn,
            this.urgentRequestDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.custReqBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(865, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // requestDateTimeDataGridViewTextBoxColumn
            // 
            this.requestDateTimeDataGridViewTextBoxColumn.DataPropertyName = "RequestDateTime";
            this.requestDateTimeDataGridViewTextBoxColumn.HeaderText = "RequestDateTime";
            this.requestDateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestDateTimeDataGridViewTextBoxColumn.Name = "requestDateTimeDataGridViewTextBoxColumn";
            this.requestDateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerUsernameDataGridViewTextBoxColumn
            // 
            this.customerUsernameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Username";
            this.customerUsernameDataGridViewTextBoxColumn.HeaderText = "Customer_Username";
            this.customerUsernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerUsernameDataGridViewTextBoxColumn.Name = "customerUsernameDataGridViewTextBoxColumn";
            this.customerUsernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemRequestIDDataGridViewTextBoxColumn
            // 
            this.itemRequestIDDataGridViewTextBoxColumn.DataPropertyName = "itemRequestID";
            this.itemRequestIDDataGridViewTextBoxColumn.HeaderText = "itemRequestID";
            this.itemRequestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemRequestIDDataGridViewTextBoxColumn.Name = "itemRequestIDDataGridViewTextBoxColumn";
            this.itemRequestIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceNoDataGridViewTextBoxColumn
            // 
            this.serviceNoDataGridViewTextBoxColumn.DataPropertyName = "ServiceNo";
            this.serviceNoDataGridViewTextBoxColumn.HeaderText = "ServiceNo";
            this.serviceNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceNoDataGridViewTextBoxColumn.Name = "serviceNoDataGridViewTextBoxColumn";
            this.serviceNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityOrderedDataGridViewTextBoxColumn
            // 
            this.quantityOrderedDataGridViewTextBoxColumn.DataPropertyName = "QuantityOrdered";
            this.quantityOrderedDataGridViewTextBoxColumn.HeaderText = "QuantityOrdered";
            this.quantityOrderedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityOrderedDataGridViewTextBoxColumn.Name = "quantityOrderedDataGridViewTextBoxColumn";
            this.quantityOrderedDataGridViewTextBoxColumn.Width = 150;
            // 
            // urgentRequestDataGridViewCheckBoxColumn
            // 
            this.urgentRequestDataGridViewCheckBoxColumn.DataPropertyName = "UrgentRequest";
            this.urgentRequestDataGridViewCheckBoxColumn.HeaderText = "UrgentRequest";
            this.urgentRequestDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.urgentRequestDataGridViewCheckBoxColumn.Name = "urgentRequestDataGridViewCheckBoxColumn";
            this.urgentRequestDataGridViewCheckBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // requestStatusDataGridViewTextBoxColumn
            // 
            this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "RequestStatus";
            this.requestStatusDataGridViewTextBoxColumn.HeaderText = "RequestStatus";
            this.requestStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
            this.requestStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // custReqBindingSource
            // 
            this.custReqBindingSource.DataMember = "CustReq";
            this.custReqBindingSource.DataSource = this.printingSystemDataSet2;
            // 
            // printingSystemDataSet2
            // 
            this.printingSystemDataSet2.DataSetName = "PrintingSystemDataSet2";
            this.printingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custReqTableAdapter
            // 
            this.custReqTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(747, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Which Payment Do You Want To Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer :";
            // 
            // custname
            // 
            this.custname.AutoSize = true;
            this.custname.BackColor = System.Drawing.Color.Transparent;
            this.custname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custname.Location = new System.Drawing.Point(674, 193);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(84, 28);
            this.custname.TabIndex = 3;
            this.custname.Text = "label3";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(831, 710);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(219, 45);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(47, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 106);
            this.label3.TabIndex = 18;
            this.label3.Text = "Make Payment";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(56, 821);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(325, 72);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.custname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "MakePayment";
            this.Text = "MakePayment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrintingSystemDataSet2 printingSystemDataSet2;
        private System.Windows.Forms.BindingSource custReqBindingSource;
        private PrintingSystemDataSet2TableAdapters.CustReqTableAdapter custReqTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRequestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentRequestDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label custname;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
    }
}
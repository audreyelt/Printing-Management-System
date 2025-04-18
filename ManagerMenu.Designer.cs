namespace FINAL_OOP
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.bntAll = new System.Windows.Forms.Button();
            this.lblCheckStatus = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.customerRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesProvidedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerRequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.workerUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custReqBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet1 = new FINAL_OOP.PrintingSystemDataSet1();
            this.custReqBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystemDataSet = new FINAL_OOP.PrintingSystemDataSet();
            this.custReqBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customeridentitiyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customeridentitiyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerRequestTableAdapter = new FINAL_OOP.PrintingSystemDataSetTableAdapters.CustomerRequestTableAdapter();
            this.custReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custReqTableAdapter = new FINAL_OOP.PrintingSystemDataSetTableAdapters.CustReqTableAdapter();
            this.custReqTableAdapter1 = new FINAL_OOP.PrintingSystemDataSet1TableAdapters.CustReqTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpn = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lblrl = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesProvidedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeridentitiyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeridentitiyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAll
            // 
            this.bntAll.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAll.Location = new System.Drawing.Point(1231, 311);
            this.bntAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntAll.Name = "bntAll";
            this.bntAll.Size = new System.Drawing.Size(104, 30);
            this.bntAll.TabIndex = 31;
            this.bntAll.Text = "All";
            this.bntAll.UseVisualStyleBackColor = true;
            this.bntAll.Click += new System.EventHandler(this.bntAll_Click);
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckStatus.Location = new System.Drawing.Point(854, 253);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(176, 45);
            this.lblCheckStatus.TabIndex = 30;
            this.lblCheckStatus.Text = "Check Status";
            this.lblCheckStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.Location = new System.Drawing.Point(810, 734);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(310, 19);
            this.lblGuide.TabIndex = 29;
            this.lblGuide.Text = "Double click to assign worker to request";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(61, 695);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(297, 74);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update User Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1231, 348);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 30);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filter by payment status:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Not Paid",
            "Paid"});
            this.comboBox1.Location = new System.Drawing.Point(1032, 330);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 29);
            this.comboBox1.TabIndex = 24;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblFilter.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(475, 333);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(117, 19);
            this.lblFilter.TabIndex = 23;
            this.lblFilter.Text = "Filter by status:";
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "New",
            "Assigned",
            "Work in Progress",
            "Completed"});
            this.cbStatusFilter.Location = new System.Drawing.Point(624, 330);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(145, 29);
            this.cbStatusFilter.TabIndex = 22;
            // 
            // customerRequestsBindingSource
            // 
            this.customerRequestsBindingSource.DataMember = "CustomerRequests";
            // 
            // servicesProvidedBindingSource
            // 
            this.servicesProvidedBindingSource.DataMember = "ServicesProvided";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.requestDateTimeDataGridViewTextBoxColumn,
            this.customerUsernameDataGridViewTextBoxColumn,
            this.itemRequestIDDataGridViewTextBoxColumn,
            this.serviceNoDataGridViewTextBoxColumn,
            this.quantityOrderedDataGridViewTextBoxColumn,
            this.urgentRequestDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.workerUserIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.custReqBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(561, 395);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(774, 318);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
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
            // workerUserIDDataGridViewTextBoxColumn
            // 
            this.workerUserIDDataGridViewTextBoxColumn.DataPropertyName = "Worker_UserID";
            this.workerUserIDDataGridViewTextBoxColumn.HeaderText = "Worker_UserID";
            this.workerUserIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workerUserIDDataGridViewTextBoxColumn.Name = "workerUserIDDataGridViewTextBoxColumn";
            this.workerUserIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // custReqBindingSource3
            // 
            this.custReqBindingSource3.DataMember = "CustReq";
            this.custReqBindingSource3.DataSource = this.printingSystemDataSet1;
            // 
            // printingSystemDataSet1
            // 
            this.printingSystemDataSet1.DataSetName = "PrintingSystemDataSet1";
            this.printingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custReqBindingSource2
            // 
            this.custReqBindingSource2.DataMember = "CustReq";
            this.custReqBindingSource2.DataSource = this.printingSystemDataSet;
            // 
            // printingSystemDataSet
            // 
            this.printingSystemDataSet.DataSetName = "PrintingSystemDataSet";
            this.printingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custReqBindingSource1
            // 
            this.custReqBindingSource1.DataMember = "CustReq";
            this.custReqBindingSource1.DataSource = this.printingSystemDataSet;
            // 
            // customeridentitiyBindingSource1
            // 
            this.customeridentitiyBindingSource1.DataMember = "customeridentitiy";
            // 
            // customeridentitiyBindingSource
            // 
            this.customeridentitiyBindingSource.DataMember = "customeridentitiy";
            // 
            // customerRequestBindingSource
            // 
            this.customerRequestBindingSource.DataMember = "CustomerRequest";
            this.customerRequestBindingSource.DataSource = this.printingSystemDataSet;
            // 
            // customerRequestTableAdapter
            // 
            this.customerRequestTableAdapter.ClearBeforeFill = true;
            // 
            // custReqBindingSource
            // 
            this.custReqBindingSource.DataMember = "CustReq";
            this.custReqBindingSource.DataSource = this.printingSystemDataSet;
            // 
            // custReqTableAdapter
            // 
            this.custReqTableAdapter.ClearBeforeFill = true;
            // 
            // custReqTableAdapter1
            // 
            this.custReqTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 73);
            this.button1.TabIndex = 33;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 57);
            this.label2.TabIndex = 34;
            this.label2.Text = "Manager Menu";
            // 
            // lbladd
            // 
            this.lbladd.BackColor = System.Drawing.Color.Transparent;
            this.lbladd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(269, 543);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(101, 23);
            this.lbladd.TabIndex = 42;
            this.lbladd.Text = "____";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Phone Number :";
            // 
            // lblpn
            // 
            this.lblpn.BackColor = System.Drawing.Color.Transparent;
            this.lblpn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpn.Location = new System.Drawing.Point(269, 500);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(101, 23);
            this.lblpn.TabIndex = 40;
            this.lblpn.Text = "____";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(83, 543);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(101, 23);
            this.address.TabIndex = 39;
            this.address.Text = "Address :";
            // 
            // lblrl
            // 
            this.lblrl.BackColor = System.Drawing.Color.Transparent;
            this.lblrl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrl.Location = new System.Drawing.Point(269, 459);
            this.lblrl.Name = "lblrl";
            this.lblrl.Size = new System.Drawing.Size(101, 23);
            this.lblrl.TabIndex = 38;
            this.lblrl.Text = "____";
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(83, 457);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(101, 23);
            this.Role.TabIndex = 37;
            this.Role.Text = "Role :";
            // 
            // lbluser
            // 
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(269, 409);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(101, 23);
            this.lbluser.TabIndex = 36;
            this.lbluser.Text = "____";
            // 
            // usrname
            // 
            this.usrname.BackColor = System.Drawing.Color.Transparent;
            this.usrname.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.Location = new System.Drawing.Point(83, 409);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(101, 23);
            this.usrname.TabIndex = 35;
            this.usrname.Text = "Username :";
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lblrl);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bntAll);
            this.Controls.Add(this.lblCheckStatus);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbStatusFilter);
            this.DoubleBuffered = true;
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.Load += new System.EventHandler(this.ManagerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesProvidedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeridentitiyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeridentitiyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custReqBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAll;
        private System.Windows.Forms.Label lblCheckStatus;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.BindingSource customerRequestsBindingSource;
        private System.Windows.Forms.BindingSource servicesProvidedBindingSource;
        private System.Windows.Forms.BindingSource customerRequestsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource customeridentitiyBindingSource;
        private System.Windows.Forms.BindingSource customeridentitiyBindingSource1;
        private PrintingSystemDataSet printingSystemDataSet;
        private System.Windows.Forms.BindingSource customerRequestBindingSource;
        private PrintingSystemDataSetTableAdapters.CustomerRequestTableAdapter customerRequestTableAdapter;
        private System.Windows.Forms.BindingSource custReqBindingSource;
        private PrintingSystemDataSetTableAdapters.CustReqTableAdapter custReqTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn workerUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource custReqBindingSource1;
        private System.Windows.Forms.BindingSource custReqBindingSource2;
        private PrintingSystemDataSet1 printingSystemDataSet1;
        private System.Windows.Forms.BindingSource custReqBindingSource3;
        private PrintingSystemDataSet1TableAdapters.CustReqTableAdapter custReqTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpn;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lblrl;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label usrname;
    }
}
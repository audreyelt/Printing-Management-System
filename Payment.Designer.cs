namespace FINAL_OOP
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrgentRequest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.PaymentBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.Location = new System.Drawing.Point(623, 708);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(186, 47);
            this.PaymentBtn.TabIndex = 38;
            this.PaymentBtn.Text = "Payment";
            this.PaymentBtn.UseVisualStyleBackColor = false;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.BackColor = System.Drawing.Color.Transparent;
            this.totalprice.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.Location = new System.Drawing.Point(1168, 566);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(42, 21);
            this.totalprice.TabIndex = 35;
            this.totalprice.Text = "____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1090, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "RECEIPT";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceType,
            this.QuantityOrdered,
            this.UrgentRequest,
            this.Cost});
            this.dataGridView2.Location = new System.Drawing.Point(623, 326);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(663, 217);
            this.dataGridView2.TabIndex = 82;
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type ";
            this.ServiceType.MinimumWidth = 8;
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.Width = 150;
            // 
            // QuantityOrdered
            // 
            this.QuantityOrdered.HeaderText = "Quantity Ordered";
            this.QuantityOrdered.MinimumWidth = 8;
            this.QuantityOrdered.Name = "QuantityOrdered";
            this.QuantityOrdered.Width = 150;
            // 
            // UrgentRequest
            // 
            this.UrgentRequest.HeaderText = "Urgent Request";
            this.UrgentRequest.MinimumWidth = 8;
            this.UrgentRequest.Name = "UrgentRequest";
            this.UrgentRequest.Width = 150;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 8;
            this.Cost.Name = "Cost";
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cost.Width = 150;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Calculate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(1094, 606);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(192, 45);
            this.Calculate.TabIndex = 83;
            this.Calculate.Text = "Calculate Total Price";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(49, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 106);
            this.label3.TabIndex = 85;
            this.label3.Text = "Payment";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 72);
            this.button1.TabIndex = 84;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrdered;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UrgentRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
namespace FINAL_OOP
{
    partial class AssignWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignWorkerForm));
            this.btnEnter = new System.Windows.Forms.Button();
            this.cbWorkerID = new System.Windows.Forms.ComboBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblWorkerID = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(851, 601);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(192, 51);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbWorkerID
            // 
            this.cbWorkerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkerID.FormattingEnabled = true;
            this.cbWorkerID.Location = new System.Drawing.Point(851, 453);
            this.cbWorkerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWorkerID.Name = "cbWorkerID";
            this.cbWorkerID.Size = new System.Drawing.Size(321, 38);
            this.cbWorkerID.TabIndex = 12;
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.Location = new System.Drawing.Point(975, 356);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(65, 30);
            this.lblRequestID.TabIndex = 11;
            this.lblRequestID.Text = "0000";
            // 
            // lblWorkerID
            // 
            this.lblWorkerID.AutoSize = true;
            this.lblWorkerID.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerID.Location = new System.Drawing.Point(602, 453);
            this.lblWorkerID.Name = "lblWorkerID";
            this.lblWorkerID.Size = new System.Drawing.Size(132, 30);
            this.lblWorkerID.TabIndex = 10;
            this.lblWorkerID.Text = "Worker ID:";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(602, 356);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(147, 30);
            this.lblRequest.TabIndex = 9;
            this.lblRequest.Text = "Request ID:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 106);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assign Worker\r\nTo Request\r\n";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(80, 815);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(325, 72);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AssignWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 944);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbWorkerID);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblWorkerID);
            this.Controls.Add(this.lblRequest);
            this.DoubleBuffered = true;
            this.Name = "AssignWorkerForm";
            this.Text = "AssignWorkerForm";
            this.Load += new System.EventHandler(this.AssignWorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cbWorkerID;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblWorkerID;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
    }
}
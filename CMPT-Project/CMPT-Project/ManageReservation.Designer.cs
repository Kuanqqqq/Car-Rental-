namespace CMPT_Project
{
    partial class ManageReservation
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
            this.button3 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.TransID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriversLicenseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(558, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 56);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back To Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.DarkCyan;
            this.update.Location = new System.Drawing.Point(369, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(183, 56);
            this.update.TabIndex = 15;
            this.update.Text = "Update Reservation";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.DarkCyan;
            this.delete.Location = new System.Drawing.Point(180, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(183, 56);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete Reservation";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TransID
            // 
            this.TransID.Location = new System.Drawing.Point(12, 39);
            this.TransID.Name = "TransID";
            this.TransID.Size = new System.Drawing.Size(154, 20);
            this.TransID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "TransactionID";
            // 
            // Transactions
            // 
            this.Transactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.PickUpDate,
            this.DropOffDate,
            this.DriversLicenseNo,
            this.EmployeeID,
            this.LicensePlatNo,
            this.BranchId});
            this.Transactions.Location = new System.Drawing.Point(-3, 110);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(744, 473);
            this.Transactions.TabIndex = 21;
            this.Transactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transactions_CellClick);
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.Name = "TransactionID";
            // 
            // PickUpDate
            // 
            this.PickUpDate.HeaderText = "PickUpDate";
            this.PickUpDate.Name = "PickUpDate";
            // 
            // DropOffDate
            // 
            this.DropOffDate.HeaderText = "DropOffDate";
            this.DropOffDate.Name = "DropOffDate";
            // 
            // DriversLicenseNo
            // 
            this.DriversLicenseNo.HeaderText = "DriversLicenseNo";
            this.DriversLicenseNo.Name = "DriversLicenseNo";
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // LicensePlatNo
            // 
            this.LicensePlatNo.HeaderText = "LicensePlateNo";
            this.LicensePlatNo.Name = "LicensePlatNo";
            // 
            // BranchId
            // 
            this.BranchId.HeaderText = "BranchID";
            this.BranchId.Name = "BranchId";
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 580);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransID);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button3);
            this.Name = "ManageReservation";
            this.Text = "ManageRentals";
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox TransID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriversLicenseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
    }
}
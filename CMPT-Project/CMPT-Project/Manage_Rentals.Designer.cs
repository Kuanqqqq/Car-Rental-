namespace CMPT_Project
{
    partial class Manage_Rentals
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
            this.LicensePlateNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriversLicenseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ReturnBranchID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AdditionalCost = new System.Windows.Forms.Label();
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
            this.button3.TabIndex = 15;
            this.button3.Text = "Back To Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // LicensePlateNo
            // 
            this.LicensePlateNo.Location = new System.Drawing.Point(12, 42);
            this.LicensePlateNo.Name = "LicensePlateNo";
            this.LicensePlateNo.Size = new System.Drawing.Size(190, 20);
            this.LicensePlateNo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "LicensePlateNo";
            // 
            // Transactions
            // 
            this.Transactions.AllowUserToAddRows = false;
            this.Transactions.AllowUserToDeleteRows = false;
            this.Transactions.AllowUserToResizeColumns = false;
            this.Transactions.AllowUserToResizeRows = false;
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
            this.Transactions.Location = new System.Drawing.Point(-3, 296);
            this.Transactions.MultiSelect = false;
            this.Transactions.Name = "Transactions";
            this.Transactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Transactions.Size = new System.Drawing.Size(744, 287);
            this.Transactions.TabIndex = 22;
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
            // TransID
            // 
            this.TransID.Location = new System.Drawing.Point(12, 90);
            this.TransID.Name = "TransID";
            this.TransID.Size = new System.Drawing.Size(190, 20);
            this.TransID.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 19);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "TransactionID";
            // 
            // ActualReturnDate
            // 
            this.ActualReturnDate.Location = new System.Drawing.Point(12, 239);
            this.ActualReturnDate.Name = "ActualReturnDate";
            this.ActualReturnDate.Size = new System.Drawing.Size(220, 20);
            this.ActualReturnDate.TabIndex = 26;
            this.ActualReturnDate.Value = new System.DateTime(2019, 6, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Return Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(558, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 56);
            this.button2.TabIndex = 28;
            this.button2.Text = "Process Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReturnBranchID
            // 
            this.ReturnBranchID.Location = new System.Drawing.Point(12, 192);
            this.ReturnBranchID.Name = "ReturnBranchID";
            this.ReturnBranchID.Size = new System.Drawing.Size(190, 20);
            this.ReturnBranchID.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Return Branch";
            // 
            // EmployID
            // 
            this.EmployID.Location = new System.Drawing.Point(12, 140);
            this.EmployID.Name = "EmployID";
            this.EmployID.Size = new System.Drawing.Size(190, 20);
            this.EmployID.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "EmployeeID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "0";
            // 
            // AdditionalCost
            // 
            this.AdditionalCost.AutoSize = true;
            this.AdditionalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdditionalCost.Location = new System.Drawing.Point(541, 221);
            this.AdditionalCost.Name = "AdditionalCost";
            this.AdditionalCost.Size = new System.Drawing.Size(147, 13);
            this.AdditionalCost.TabIndex = 34;
            this.AdditionalCost.Text = "Additional Cost(Gas/Damage)";
            // 
            // Manage_Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 580);
            this.Controls.Add(this.AdditionalCost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnBranchID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActualReturnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TransID);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicensePlateNo);
            this.Controls.Add(this.button3);
            this.Name = "Manage_Rentals";
            this.Text = "Manage_Rentals";
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox LicensePlateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriversLicenseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
        private System.Windows.Forms.TextBox TransID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ActualReturnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ReturnBranchID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AdditionalCost;
    }
}
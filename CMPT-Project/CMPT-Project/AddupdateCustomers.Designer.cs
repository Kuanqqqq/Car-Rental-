namespace CMPT_Project
{
    partial class AddupdateCustomers
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
            this.back = new System.Windows.Forms.Button();
            this.CustomerInfo = new System.Windows.Forms.DataGridView();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlateNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LicenseBox = new System.Windows.Forms.TextBox();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.LastN = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.CreditBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DarkCyan;
            this.back.Location = new System.Drawing.Point(656, 1);
            this.back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(183, 56);
            this.back.TabIndex = 1;
            this.back.Text = "Back to Main Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drivers,
            this.fName,
            this.lName,
            this.Address,
            this.Credit});
            this.CustomerInfo.Location = new System.Drawing.Point(0, 238);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(839, 289);
            this.CustomerInfo.TabIndex = 3;
            this.CustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerInfo_CellClick);
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "Driver\'s License Number";
            this.Drivers.Name = "Drivers";
            // 
            // fName
            // 
            this.fName.HeaderText = "FirstName";
            this.fName.Name = "fName";
            // 
            // lName
            // 
            this.lName.HeaderText = "LastName";
            this.lName.Name = "lName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit Card";
            this.Credit.Name = "Credit";
            // 
            // LicensePlateNo
            // 
            this.LicensePlateNo.AutoSize = true;
            this.LicensePlateNo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicensePlateNo.ForeColor = System.Drawing.Color.White;
            this.LicensePlateNo.Location = new System.Drawing.Point(11, 13);
            this.LicensePlateNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LicensePlateNo.Name = "LicensePlateNo";
            this.LicensePlateNo.Size = new System.Drawing.Size(210, 28);
            this.LicensePlateNo.TabIndex = 6;
            this.LicensePlateNo.Text = "Driver\'s License #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Credit Card";
            // 
            // LicenseBox
            // 
            this.LicenseBox.Location = new System.Drawing.Point(242, 16);
            this.LicenseBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LicenseBox.Multiline = true;
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.Size = new System.Drawing.Size(161, 25);
            this.LicenseBox.TabIndex = 12;
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(242, 56);
            this.FirstN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstN.Multiline = true;
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(161, 25);
            this.FirstN.TabIndex = 13;
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(242, 102);
            this.LastN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LastN.Multiline = true;
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(161, 25);
            this.LastN.TabIndex = 14;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(242, 143);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(161, 25);
            this.AddressBox.TabIndex = 15;
            // 
            // CreditBox
            // 
            this.CreditBox.Location = new System.Drawing.Point(242, 188);
            this.CreditBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreditBox.Multiline = true;
            this.CreditBox.Name = "CreditBox";
            this.CreditBox.Size = new System.Drawing.Size(161, 25);
            this.CreditBox.TabIndex = 16;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(460, 98);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 43);
            this.Add.TabIndex = 29;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(460, 153);
            this.Update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(108, 43);
            this.Update.TabIndex = 30;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(460, 43);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 43);
            this.Search.TabIndex = 31;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AddupdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(840, 527);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CreditBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.LastN);
            this.Controls.Add(this.FirstN);
            this.Controls.Add(this.LicenseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicensePlateNo);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.back);
            this.Name = "AddupdateCustomers";
            this.Text = "AddupdateCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView CustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Label LicensePlateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LicenseBox;
        private System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox CreditBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
    }
}
namespace CMPT_Project
{
    partial class MakeReservation
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
            this.DriversLicenseNo = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.BranchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PickUpDate = new System.Windows.Forms.DateTimePicker();
            this.DropOffDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriversLicenseNo
            // 
            this.DriversLicenseNo.BackColor = System.Drawing.SystemColors.Window;
            this.DriversLicenseNo.Location = new System.Drawing.Point(72, 170);
            this.DriversLicenseNo.Name = "DriversLicenseNo";
            this.DriversLicenseNo.Size = new System.Drawing.Size(153, 20);
            this.DriversLicenseNo.TabIndex = 0;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(72, 250);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(153, 20);
            this.EmployeeID.TabIndex = 1;
            // 
            // BranchID
            // 
            this.BranchID.Location = new System.Drawing.Point(451, 250);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(153, 20);
            this.BranchID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(69, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DriversLicenseNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(69, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EmployeeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(448, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BranchID";
            // 
            // PickUpDate
            // 
            this.PickUpDate.Location = new System.Drawing.Point(264, 170);
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Size = new System.Drawing.Size(142, 20);
            this.PickUpDate.TabIndex = 6;
            // 
            // DropOffDate
            // 
            this.DropOffDate.Location = new System.Drawing.Point(264, 250);
            this.DropOffDate.Name = "DropOffDate";
            this.DropOffDate.Size = new System.Drawing.Size(142, 20);
            this.DropOffDate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Make Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(451, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Select Car";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "Get Avalible Cars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(261, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DropOffDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(261, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PickUpDate";
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
            this.button3.TabIndex = 13;
            this.button3.Text = "Back To Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 580);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DropOffDate);
            this.Controls.Add(this.PickUpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.DriversLicenseNo);
            this.Name = "MakeReservation";
            this.Text = "MakeReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DriversLicenseNo;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.TextBox BranchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PickUpDate;
        private System.Windows.Forms.DateTimePicker DropOffDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}
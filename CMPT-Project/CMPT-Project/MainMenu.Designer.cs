namespace CMPT_Project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ViewRet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewReports = new System.Windows.Forms.Button();
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.AddUpdateCus = new System.Windows.Forms.Button();
            this.UpdateCar = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.Rentals = new System.Windows.Forms.Button();
            this.ReservePanel = new System.Windows.Forms.Panel();
            this.Manage_Res = new System.Windows.Forms.Button();
            this.Reserve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.ManagePanel.SuspendLayout();
            this.ReservePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-2, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 152);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.White;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.CadetBlue;
            this.View.Location = new System.Drawing.Point(29, 69);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(273, 53);
            this.View.TabIndex = 1;
            this.View.Text = "View Available Cars";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.CadetBlue;
            this.update.Location = new System.Drawing.Point(29, 69);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(273, 53);
            this.update.TabIndex = 3;
            this.update.Text = "Update Car Location";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.ReserveButton);
            this.panel1.Controls.Add(this.ManageButton);
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 580);
            this.panel1.TabIndex = 4;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(206, 153);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 75);
            this.SidePanel.TabIndex = 4;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(0, 400);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(200, 77);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.FlatAppearance.BorderSize = 0;
            this.ReserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveButton.ForeColor = System.Drawing.Color.White;
            this.ReserveButton.Location = new System.Drawing.Point(0, 317);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(200, 77);
            this.ReserveButton.TabIndex = 2;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.FlatAppearance.BorderSize = 0;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.ForeColor = System.Drawing.Color.White;
            this.ManageButton.Location = new System.Drawing.Point(0, 234);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(200, 77);
            this.ManageButton.TabIndex = 1;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.Location = new System.Drawing.Point(0, 151);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(200, 77);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.side.Location = new System.Drawing.Point(203, 153);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(6, 68);
            this.side.TabIndex = 5;
            // 
            // ViewPanel
            // 
            this.ViewPanel.Controls.Add(this.ViewRet);
            this.ViewPanel.Controls.Add(this.button1);
            this.ViewPanel.Controls.Add(this.ViewReports);
            this.ViewPanel.Controls.Add(this.View);
            this.ViewPanel.Location = new System.Drawing.Point(215, 126);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(677, 454);
            this.ViewPanel.TabIndex = 6;
            // 
            // ViewRet
            // 
            this.ViewRet.BackColor = System.Drawing.Color.White;
            this.ViewRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRet.ForeColor = System.Drawing.Color.CadetBlue;
            this.ViewRet.Location = new System.Drawing.Point(373, 206);
            this.ViewRet.Name = "ViewRet";
            this.ViewRet.Size = new System.Drawing.Size(273, 53);
            this.ViewRet.TabIndex = 4;
            this.ViewRet.Text = "View Returns";
            this.ViewRet.UseVisualStyleBackColor = false;
            this.ViewRet.Click += new System.EventHandler(this.ViewRet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(29, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Customers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ViewCus_Click);
            // 
            // ViewReports
            // 
            this.ViewReports.BackColor = System.Drawing.Color.White;
            this.ViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReports.ForeColor = System.Drawing.Color.CadetBlue;
            this.ViewReports.Location = new System.Drawing.Point(373, 69);
            this.ViewReports.Name = "ViewReports";
            this.ViewReports.Size = new System.Drawing.Size(273, 53);
            this.ViewReports.TabIndex = 2;
            this.ViewReports.Text = "View Reports";
            this.ViewReports.UseVisualStyleBackColor = false;
            this.ViewReports.Click += new System.EventHandler(this.ViewReports_Click);
            // 
            // ManagePanel
            // 
            this.ManagePanel.Controls.Add(this.AddUpdateCus);
            this.ManagePanel.Controls.Add(this.UpdateCar);
            this.ManagePanel.Controls.Add(this.AddCar);
            this.ManagePanel.Controls.Add(this.Rentals);
            this.ManagePanel.Controls.Add(this.update);
            this.ManagePanel.Location = new System.Drawing.Point(215, 126);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.Size = new System.Drawing.Size(677, 454);
            this.ManagePanel.TabIndex = 7;
            // 
            // AddUpdateCus
            // 
            this.AddUpdateCus.BackColor = System.Drawing.Color.White;
            this.AddUpdateCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUpdateCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateCus.ForeColor = System.Drawing.Color.CadetBlue;
            this.AddUpdateCus.Location = new System.Drawing.Point(195, 319);
            this.AddUpdateCus.Name = "AddUpdateCus";
            this.AddUpdateCus.Size = new System.Drawing.Size(273, 53);
            this.AddUpdateCus.TabIndex = 6;
            this.AddUpdateCus.Text = "Add/Update Customers";
            this.AddUpdateCus.UseVisualStyleBackColor = false;
            this.AddUpdateCus.Click += new System.EventHandler(this.AddUpdateCus_Click);
            // 
            // UpdateCar
            // 
            this.UpdateCar.BackColor = System.Drawing.Color.White;
            this.UpdateCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCar.ForeColor = System.Drawing.Color.CadetBlue;
            this.UpdateCar.Location = new System.Drawing.Point(373, 206);
            this.UpdateCar.Name = "UpdateCar";
            this.UpdateCar.Size = new System.Drawing.Size(273, 53);
            this.UpdateCar.TabIndex = 5;
            this.UpdateCar.Text = "Update/Remove Cars";
            this.UpdateCar.UseVisualStyleBackColor = false;
            this.UpdateCar.Click += new System.EventHandler(this.UpdateRemove_Click);
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.Color.White;
            this.AddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCar.ForeColor = System.Drawing.Color.CadetBlue;
            this.AddCar.Location = new System.Drawing.Point(29, 206);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(273, 53);
            this.AddCar.TabIndex = 4;
            this.AddCar.Text = "Add A New Car";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // Rentals
            // 
            this.Rentals.BackColor = System.Drawing.Color.White;
            this.Rentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentals.ForeColor = System.Drawing.Color.CadetBlue;
            this.Rentals.Location = new System.Drawing.Point(373, 69);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(273, 53);
            this.Rentals.TabIndex = 2;
            this.Rentals.Text = "Returns";
            this.Rentals.UseVisualStyleBackColor = false;
            this.Rentals.Click += new System.EventHandler(this.Rentals_Click);
            // 
            // ReservePanel
            // 
            this.ReservePanel.Controls.Add(this.Manage_Res);
            this.ReservePanel.Controls.Add(this.Reserve);
            this.ReservePanel.Location = new System.Drawing.Point(215, 126);
            this.ReservePanel.Name = "ReservePanel";
            this.ReservePanel.Size = new System.Drawing.Size(677, 454);
            this.ReservePanel.TabIndex = 8;
            // 
            // Manage_Res
            // 
            this.Manage_Res.BackColor = System.Drawing.Color.White;
            this.Manage_Res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage_Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Res.ForeColor = System.Drawing.Color.CadetBlue;
            this.Manage_Res.Location = new System.Drawing.Point(373, 69);
            this.Manage_Res.Name = "Manage_Res";
            this.Manage_Res.Size = new System.Drawing.Size(273, 53);
            this.Manage_Res.TabIndex = 5;
            this.Manage_Res.Text = "Manage Reservation";
            this.Manage_Res.UseVisualStyleBackColor = false;
            this.Manage_Res.Click += new System.EventHandler(this.Manage_Res_Click);
            // 
            // Reserve
            // 
            this.Reserve.BackColor = System.Drawing.Color.White;
            this.Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve.ForeColor = System.Drawing.Color.CadetBlue;
            this.Reserve.Location = new System.Drawing.Point(29, 69);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(273, 53);
            this.Reserve.TabIndex = 3;
            this.Reserve.Text = "Reserve A Vehicle";
            this.Reserve.UseVisualStyleBackColor = false;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(893, 580);
            this.Controls.Add(this.side);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.ReservePanel);
            this.Controls.Add(this.ManagePanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.ViewPanel.ResumeLayout(false);
            this.ManagePanel.ResumeLayout(false);
            this.ReservePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button ViewReports;
        private System.Windows.Forms.Panel ManagePanel;
        private System.Windows.Forms.Button Rentals;
        private System.Windows.Forms.Panel ReservePanel;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button Manage_Res;
        private System.Windows.Forms.Button UpdateCar;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddUpdateCus;
        private System.Windows.Forms.Button ViewRet;
    }
}


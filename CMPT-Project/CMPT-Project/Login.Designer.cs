namespace CMPT_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.EmID = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(418, 192);
            this.EmployeeID.Multiline = true;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(244, 32);
            this.EmployeeID.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(418, 292);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(244, 31);
            this.Password.TabIndex = 10;
            // 
            // EmID
            // 
            this.EmID.BackColor = System.Drawing.Color.Transparent;
            this.EmID.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmID.ForeColor = System.Drawing.Color.CadetBlue;
            this.EmID.Location = new System.Drawing.Point(144, 192);
            this.EmID.Name = "EmID";
            this.EmID.Size = new System.Drawing.Size(203, 44);
            this.EmID.TabIndex = 6;
            this.EmID.Text = "Employee ID";
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.CadetBlue;
            this.Pass.Location = new System.Drawing.Point(144, 285);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(203, 38);
            this.Pass.TabIndex = 8;
            this.Pass.Text = "Password";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.DarkCyan;
            this.log.Location = new System.Drawing.Point(296, 371);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(176, 55);
            this.log.TabIndex = 7;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 126);
            this.label1.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(731, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmID);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.log);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label EmID;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label1;
    }
}
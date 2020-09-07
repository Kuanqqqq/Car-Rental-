using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_Project
{
    public partial class Login : Form
    {
        public database datab;
        public Login()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                datab = new database(EmployeeID.Text, Password.Text);
                this.Hide();
                MainMenu m = new MainMenu(datab);
                m.ShowDialog();
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Invalid ID or Password");

            }
        }
    }
}

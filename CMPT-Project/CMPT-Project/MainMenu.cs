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
    public partial class MainMenu : Form
    {
        public database datab;
        public MainMenu(database temp)
        {
            InitializeComponent();
            datab = temp;
            ViewPanel.Visible = true;
            ManagePanel.Visible = false;
            ReservePanel.Visible = false;
        }

        private void View_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCars v = new ViewCars(datab);
            v.ShowDialog();
            this.Close();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateLocationForm u = new UpdateLocationForm(datab);
            u.ShowDialog();
            this.Close();

        }

        private void UpdateRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateRemoveForm up = new UpdateRemoveForm(datab);
            up.ShowDialog();
            this.Close();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            side.Height = ViewButton.Height;
            side.Top = ViewButton.Top;
            ViewPanel.Visible = true;
            ManagePanel.Visible = false;
            ReservePanel.Visible = false;
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            side.Height = ManageButton.Height;
            side.Top = ManageButton.Top;
            ViewPanel.Visible = false;
            ManagePanel.Visible = true;
            ReservePanel.Visible = false;
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            
            side.Height = ReserveButton.Height;
            side.Top = ReserveButton.Top;
            ViewPanel.Visible = false;
            ManagePanel.Visible = false;
            ReservePanel.Visible = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            side.Height = LogoutButton.Height;
            side.Top = LogoutButton.Top;
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void ViewReports_Click(object sender, EventArgs e)
        {

        }

        private void Rentals_Click(object sender, EventArgs e)
        {
            this.Hide();
            Returns u = new Returns(datab);
            u.ShowDialog();
            this.Close();

        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeReservation u = new MakeReservation(datab);
            u.ShowDialog();
            this.Close();
        }

        private void Manage_Res_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageReservation u = new ManageReservation(datab);
            u.ShowDialog();
            this.Close();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCars A = new AddCars(datab);
            A.ShowDialog();
            this.Close();
        }

        private void ViewCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomers v = new ViewCustomers(datab);
            v.ShowDialog();
            this.Close();
        }

        private void AddUpdateCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddupdateCustomers a = new AddupdateCustomers(datab);
            a.ShowDialog();
            this.Close();
        }

        private void ViewRet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReturns v = new ViewReturns(datab);
            v.ShowDialog();
            this.Close();
        }
    }
}

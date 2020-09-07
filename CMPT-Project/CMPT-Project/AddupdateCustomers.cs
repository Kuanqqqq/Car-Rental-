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
    public partial class AddupdateCustomers : Form
    {
        public database datab;

        public AddupdateCustomers(database temp)
        {
            InitializeComponent();
            datab = temp;

            string command = "select * from Customers";
            try
            {
                datab.query(command);
                CustomerInfo.Rows.Clear();
                while (datab.myReader.Read())
                {
                    CustomerInfo.Rows.Add(datab.myReader["DriversLicenseNo"].ToString(), datab.myReader["fName"].ToString()
                        , datab.myReader["lName"].ToString(), datab.myReader["Address"].ToString(), datab.myReader["CreditCard"].ToString());
                }
                datab.myReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(datab);
            m.ShowDialog();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string command = "insert into Customers values('" + LicenseBox.Text + "','" + FirstN.Text + "','" +
                LastN.Text + "','" + AddressBox.Text + "','" + CreditBox.Text + "')";
            try
            {
                datab.UpdateData(command);
                MessageBox.Show("Customer has been Successfully added to the database");
                this.Hide();
                AddupdateCustomers u = new AddupdateCustomers(datab);
                u.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Driver's License Number already exist in the database");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string command = "select * from Customers where DriversLicenseNo = '" + LicenseBox.Text + "'";
            datab.query(command);
            while (datab.myReader.Read())
            {
                if (LicenseBox.Text == datab.myReader["DriversLicenseNo"].ToString())
                {
                    FirstN.Text = datab.myReader["fName"].ToString();
                    LastN.Text = datab.myReader["lName"].ToString();
                    AddressBox.Text = datab.myReader["Address"].ToString();
                    CreditBox.Text = datab.myReader["CreditCard"].ToString();

                }
                else
                {
                    MessageBox.Show("No valid Drivers License Number.");
                }
            }
            datab.myReader.Close();
        }

        private void CustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CustomerInfo.CurrentRow.Selected = true;
                LicenseBox.Text = CustomerInfo.Rows[e.RowIndex].Cells["Drivers"].FormattedValue.ToString();
                FirstN.Text = CustomerInfo.Rows[e.RowIndex].Cells["fName"].FormattedValue.ToString();
                LastN.Text = CustomerInfo.Rows[e.RowIndex].Cells["lName"].FormattedValue.ToString();
                AddressBox.Text = CustomerInfo.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                CreditBox.Text = CustomerInfo.Rows[e.RowIndex].Cells["Credit"].FormattedValue.ToString();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string command = "update Customers set fName = '" + FirstN.Text +"', lName = '" + LastN.Text + "', Address = '" + AddressBox.Text
                + "', CreditCard = '" + CreditBox.Text + "' where DriversLicenseNo = '" + LicenseBox.Text + "'";
            try
            {
                datab.UpdateData(command);
                MessageBox.Show("Successfully updated information for customer: " + LicenseBox.Text);
                this.Hide();
                AddupdateCustomers u = new AddupdateCustomers(datab);
                u.ShowDialog();
                this.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show("Please make sure the License Number is valid");
            }
        }
    }
}

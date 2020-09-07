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
    public partial class ManageReservation : Form
    {
        public database datab;
        public ManageReservation(database temp)
        {
            InitializeComponent();
            datab = temp;

            string command = "select * from Transactions";

            try
            {
                datab.query(command);
                Transactions.Rows.Clear();
                while (datab.myReader.Read())
                {
                    Transactions.Rows.Add(datab.myReader["TransactionID"].ToString(), datab.myReader["PickUpDate"].ToString(),
                        datab.myReader["ScheduledDropDate"].ToString(), datab.myReader["DriversLicenseNo"].ToString(),
                        datab.myReader["EmployeeID"].ToString(), datab.myReader["LicensePlateNo"].ToString(),
                        datab.myReader["BranchID"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(datab);
            m.ShowDialog();
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (TransID.Text != "")
            {
                try
                {
                    String transID = TransID.Text;
                    string command = "select * from Transactions where TransactionID=" + transID;
                    datab.query(command);
                    if (datab.myReader.Read())
                    {
                        datab.myReader.Close();
                        this.Hide();
                        UpdateReservations u = new UpdateReservations(TransID.Text, datab);
                        u.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        datab.myReader.Close();
                        MessageBox.Show("please enter Valid TransactionID");
                    }

                    
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("please enter TransactionID");
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string command = "Delete from Transactions where TransactionID="+TransID.Text;
            try
            {
                datab.UpdateData(command);
                MessageBox.Show("Successfully updated Reservation");
                this.Hide();
                ManageReservation u = new ManageReservation(datab);
                u.ShowDialog();
                this.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Please make sure TransactionID is valid");
            }

        }

        private void Transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Transactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Transactions.CurrentRow.Selected = true;
                TransID.Text = Transactions.Rows[e.RowIndex].Cells["TransactionID"].FormattedValue.ToString(); 

            }
        }


    }
}

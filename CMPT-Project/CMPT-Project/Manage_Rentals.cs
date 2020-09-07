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

    public partial class Manage_Rentals : Form
    {
        public database datab;
        public Manage_Rentals(database temp)
        {
            InitializeComponent();
            datab = temp;

        }

        private void Transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Transactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Transactions.CurrentRow.Selected = true;
                TransID.Text = Transactions.Rows[e.RowIndex].Cells["TransactionID"].FormattedValue.ToString();
                LicensePlateNo.Text = Transactions.Rows[e.RowIndex].Cells["LicensePlatNo"].FormattedValue.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LicensePlateNo.Text != "")
            {
                string command = "select * from Transactions where LicensePlateNo='"+ LicensePlateNo.Text+"'";

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float cost,latefee,costperday,branchpenalty;
            cost = 0;
            latefee = 0;
            costperday = 0;
            branchpenalty = 0;
            string command = "select * from Transactions where TransactionID="+TransID.Text;
            DateTime pickup, dropoff;
            pickup = new DateTime(2019,6,13);
            dropoff=new DateTime(2019, 6, 13);
            int branchid=999;
            String driverslicense = "HIO-4397";
            String golden = "";

            try
            {
                datab.query(command);
                while (datab.myReader.Read())
                {
                    pickup= Convert.ToDateTime(datab.myReader["PickUpDate"].ToString());
                    dropoff= Convert.ToDateTime(datab.myReader["ScheduledDropDate"].ToString());
                    branchid = Convert.ToInt32(datab.myReader["BranchID"].ToString());
                    driverslicense = datab.myReader["DriversLicenseNo"].ToString();
                }
                datab.myReader.Close();
                command = "SELECT * FROM cars as a,cartype as b where a.TypeID=b.TypeID and LicensePlateNo='"+LicensePlateNo.Text+"'";
                datab.query(command);
                while (datab.myReader.Read())
                {
                    latefee = Convert.ToInt32(datab.myReader["LatePenalty"].ToString());
                    costperday = Convert.ToInt32(datab.myReader["CostPerDay"].ToString());
                    branchpenalty = Convert.ToInt32(datab.myReader["BranchPenalty"].ToString());

                }
                datab.myReader.Close();
                command = "SELECT * FROM Golden where DriversLicenseNo='" + driverslicense+"'";
                datab.query(command);
                while (datab.myReader.Read())
                {
                    golden = datab.myReader["Since"].ToString();

                }
                datab.myReader.Close();
                cost = ((ActualReturnDate.Value.DayOfYear-pickup.DayOfYear)*costperday)+Convert.ToInt32(textBox1.Text);
                if (branchid != Convert.ToInt32(ReturnBranchID.Text)&&golden=="")
                {
                    cost += branchpenalty;
                }
                if (ActualReturnDate.Value.DayOfYear - dropoff.DayOfYear > 0)
                {
                    cost += ((ActualReturnDate.Value.DayOfYear - dropoff.DayOfYear) * costperday)+latefee;
                }



            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "");
            }
            command = "insert into ReturnTo  values(" + TransID.Text+","+ ReturnBranchID.Text + ","+ EmployID.Text + ","+cost+",'" +ActualReturnDate.Value+"')";
            try
            {
                datab.UpdateData(command);
                MessageBox.Show("Successfully processed");
                this.Hide();
                MainMenu m = new MainMenu(datab);
                m.ShowDialog();
                this.Close();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Please make sure the Values are valid");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(datab);
            m.ShowDialog();
            this.Close();
        }
    }
}

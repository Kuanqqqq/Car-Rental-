using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_Project
{
    public partial class MakeReservation : Form
    {
        public database datab;
        public MakeReservation(database temp)
        {
            InitializeComponent();
            datab = temp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String sql;
            int output, transid;
            transid = 0;
            sql = "Select * from Transactions";
            SqlCommand command;
            try
            {
                datab.query(sql);
                while (datab.myReader.Read())
                {
                    output = datab.myReader.GetInt32(0);
                    if (output >= transid) { transid = output + 1; }
                }
                datab.myReader.Close();

                String employeeid = EmployeeID.Text;
                String branchid = BranchID.Text;
                DateTime pickup, dropoff;
                String driverlicenseno, LicensePlateNo;
                pickup = PickUpDate.Value;
                dropoff = DropOffDate.Value;
                driverlicenseno = DriversLicenseNo.Text;
                LicensePlateNo = comboBox1.Text.Split(' ').Last();
                SqlDataAdapter adapter = new SqlDataAdapter();
                sql = "insert into Transactions (TransactionID,PickUpDate,ScheduledDropDate,DriversLicenseNo,EmployeeID,LicensePlateNo,BranchID) " +
                    "values(" + transid + ",'" + pickup + "','" + dropoff + "','" + driverlicenseno + "'," + employeeid + ",'" + LicensePlateNo + "'," + branchid + ")";
                command = new SqlCommand(sql, datab.myCommand.Connection);
                adapter.InsertCommand = new SqlCommand(sql, datab.myCommand.Connection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Reservation succesfull");
                this.Hide();
                MainMenu m = new MainMenu(datab);
                m.ShowDialog();
                this.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Please make sure information entered is valid");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> transactions = new List<String>();
                String license;
                String command1 = "SELECT * FROM Transactions where BranchID=" + BranchID.Text + "and (pickupdate<'" + DropOffDate.Value + "'and scheduleddropdate>'" + DropOffDate.Value + "')and (pickupdate<'" + PickUpDate.Value + "'and scheduleddropdate>'" + PickUpDate.Value + "')";
                datab.query(command1);
                while (datab.myReader.Read())
                {
                    transactions.Add(datab.myReader["LicensePlateNo"].ToString());

                }
                datab.myReader.Close();
                SqlCommand command;
                SqlDataReader datareader;
                String sql, output;
                sql = "SELECT LicensePlateNo,a.TypeID,Brand,Model,BranchID FROM cars as a,cartype as b where a.TypeID=b.TypeID and BranchID=" + BranchID.Text;
                command = new SqlCommand(sql, datab.myCommand.Connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    if (!transactions.Contains(datareader.GetString(1)))
                    {
                        output = datareader.GetString(1) + " " + datareader.GetString(2) + " " + datareader.GetString(3) + " " + datareader.GetString(0);
                        comboBox1.Items.Add(output);
                    }
                }
                command.Dispose();
                datareader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Please enter valid values");
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

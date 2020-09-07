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
    public partial class AddCars : Form
    {
        public database datab;

        public AddCars(database temp)
        {
            InitializeComponent();
            datab = temp;
            ComboFill();
        }

        public void ComboFill()
        {
            string command = "select * from Branch";

            try
            {
                datab.query(command);
                BranchCombo.Items.Clear();
                while (datab.myReader.Read())
                {
                    BranchCombo.Items.Add(datab.myReader["BranchID"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }


            string NewCommand = "select * from CarType";

            try
            {
                datab.query(NewCommand);
                TypeCombo.Items.Clear();
                while (datab.myReader.Read())
                {
                    TypeCombo.Items.Add(datab.myReader["TypeID"].ToString());
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(datab);
            m.ShowDialog();
            this.Close();
        }

        private void BranchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "select * from Branch where BranchID = " + BranchCombo.Text;

            try
            {
                datab.query(command);
                while (datab.myReader.Read())
                {
                    BranchPen.Text = datab.myReader["BranchPenalty"].ToString();
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "select * from CarType where TypeID = '" + TypeCombo.Text + "'";

            try
            {
                datab.query(command);
                while (datab.myReader.Read())
                {
                    LatePen.Text = datab.myReader["LatePenalty"].ToString();
                    Cost.Text = datab.myReader["CostPerDay"].ToString();
                }

                datab.myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string command = "insert into Cars values ('" + LicenseBox.Text + "', '" + BrandBox.Text  + "', '" + ModelBox.Text + "', " + Mileage.Text + ", '" + GasBox.Text + "', '" + ConditionBox.Text + "', " +
                BranchCombo.Text + ",'" + TypeCombo.Text + "')";

            try
            {
                datab.UpdateData(command);
                MessageBox.Show("Car added successfully");
                LicenseBox.Clear();
                BrandBox.Clear();
                ModelBox.Clear();
                Mileage.Clear();
                GasBox.Clear();
                ConditionBox.Clear();
                BranchPen.Clear();
                LatePen.Clear();
                Cost.Clear();
                BranchCombo.Text = String.Empty;
                TypeCombo.Text = String.Empty;
               

            }
            catch (Exception e2)
            {
                MessageBox.Show("This Car is already in the Database");
            }
        }

        private void AddCars_Load(object sender, EventArgs e)
        {

        }
    }
}

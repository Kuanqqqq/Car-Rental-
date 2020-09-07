using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT_Project
{
    public class database
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public database(string username, string password)
        {
            /* Starting the connection */
            SqlConnection myConnection = new SqlConnection("user id=" + username + ";" + // Username
                                       "password=" + password + ";" + // Password
                                       "server=localhost;" + // IP for the server
                                       "Trusted_Connection=yes;" +
                                       "database=CMPT291_Project; " + // Database to connect to
                                       "connection timeout=30"); // Timeout in seconds


            myConnection.Open(); // Open connection
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Link the command stream to the connection

        }
        //
        public void UpdateData(string command)
        {

            myCommand.CommandText = command;
            //MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();


        }
        //
        public void query(string command)
        {

            myCommand.CommandText = command;
            //MessageBox.Show("Fetching Available Cars");
            myReader = myCommand.ExecuteReader();

        }
    }
}

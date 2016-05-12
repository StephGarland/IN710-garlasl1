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

namespace Practical_11._1_Assignment_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN710_201601_GARLASL1;" +
                                                "User ID = garlasl1;" +
                                                "Password = PASSWORD;";

            bitdevConnection.Open();
            
            string selectQuery = "SELECT fireLongitude from dbo.tblFire";
            SqlCommand worldCommand = new SqlCommand();
            worldCommand.Connection = bitdevConnection;
            worldCommand.CommandText = selectQuery;

            SqlDataReader worldReader;
            worldReader = worldCommand.ExecuteReader();
            while (worldReader.Read())
            {
                listBox1.Items.Add(worldReader["fireLongitude"].ToString());
            }

            worldReader.Close();
            bitdevConnection.Close();
        }

        private void btn_Papers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Grades_Click(object sender, EventArgs e)
        {

        }

        private void btn_Assignments_Click(object sender, EventArgs e)
        {

        }
    }
}

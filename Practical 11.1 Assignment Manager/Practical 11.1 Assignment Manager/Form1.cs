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
                                                "Password = SGa_F845;";


            string createTutorTable = @"CREATE TABLE tblTutor
                                        (
                                            tutorID int IDENTITY(1,1) PRIMARY KEY,
                                            lastName varchar(20) NOT NULL,
                                            firstName varchar(20) NOT NULL,
                                            email varchar(100),
                                        );";

            string insertQuery = @"INSERT INTO tblTutor (lastName,firstName,email)
                                    VALUES('Lockhart', 'Gilderoy', 'lockhart.gilderoy@hw.ac.nz');";


            bitdevConnection.Open();

            //SqlCommand cmdCreateTutorTable = new SqlCommand(createTutorTable, bitdevConnection);
            //cmdCreateTutorTable.ExecuteNonQuery();
            //SqlCommand cmdInsertTutor = new SqlCommand(insertQuery, bitdevConnection);
           // cmdInsertTutor.ExecuteNonQuery();


            //"SELECT fireLongitude from dbo.tblFire"
            string selectQuery = "SELECT lastName from dbo.tblTutor";
            SqlCommand worldCommand = new SqlCommand();
            worldCommand.Connection = bitdevConnection;
            worldCommand.CommandText = selectQuery;

            SqlDataReader worldReader;
            worldReader = worldCommand.ExecuteReader();
            while (worldReader.Read())
            {
                listBox1.Items.Add(worldReader["lastName"].ToString());
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

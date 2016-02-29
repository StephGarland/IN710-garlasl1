using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2._2_Best_Movie_database
{
    public partial class Form1 : Form
    {
        MovieDatabase database;
        public Form1()
        {
            InitializeComponent();
            database = new MovieDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listboxPrint.Items.Clear();
            try
            {
                int year = Convert.ToInt32(txtAddYear.Text);
                string title = txtAddTitle.Text;
                string director = txtAddDirector.Text;

                if (database.Add(year, title, director))
                {
                    listboxPrint.Items.Add("New entry created: " + database.Find(year).ToString());
                }
                else
                {
                    listboxPrint.Items.Add("Error: Entry already exists for this year");
                }
            }
            catch (FormatException)
            {
                listboxPrint.Items.Add("Invalid Input. Year, title and director required.");
                listboxPrint.Items.Add("Year should be numerical only.");
            }
            catch (OverflowException)
            {
                listboxPrint.Items.Add("Please remove cat from keyboard.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listboxPrint.Items.Clear();
            try
            {
                int year = Convert.ToInt32(txtDeleteYear.Text);

                if (database.Delete(year))
                {
                    listboxPrint.Items.Add("Entry Deleted.");
                }
                else
                {
                    listboxPrint.Items.Add("Error: No results found for this year.");
                }
            }
            catch (FormatException)
            {
                listboxPrint.Items.Add("Invalid Input. Year should be numerical only.");
            }
            catch (OverflowException)
            {
                listboxPrint.Items.Add("Please remove cat from keyboard.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listboxPrint.Items.Clear();
            try
            {
                int year = Convert.ToInt32(txtSearchYear.Text);
                Movie movie = database.Find(year);

                if (movie != null)
                {
                    listboxPrint.Items.Add(movie.ToString());
                }
                else
                {
                    listboxPrint.Items.Add("No results found for this year.");
                }
            }
            catch (FormatException)
            {
                listboxPrint.Items.Add("Invalid Input. Year should be numerical only.");
            }
            catch (OverflowException)
            {
                listboxPrint.Items.Add("Please remove cat from keyboard.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Movie> movies = database.AsList();
            movies.Sort();
            listboxPrint.Items.Clear();
            foreach (Movie movie in movies)
            {
                listboxPrint.Items.Add(movie.ToString());
            }
        }
    }
}

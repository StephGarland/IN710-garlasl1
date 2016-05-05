using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Art_Database_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Artist> artists;
        public List<Painting> paintings;

        private void Form1_Load(object sender, EventArgs e)
        {
            artists = new List<Artist>();
            artists.Add(new Artist { Country = "France", FirstName = "Camille", LastName = "Pissarro", YearOfBirth = 1830, YearOfDeath = 1903 });
            artists.Add(new Artist { Country = "France", FirstName = "Claude", LastName = "Monet", YearOfBirth = 1840, YearOfDeath = 1926 });
            artists.Add(new Artist { Country = "England", FirstName = "John", LastName = "Constable", YearOfBirth = 1776, YearOfDeath = 1837 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Jan", LastName = "Vermeer", YearOfBirth = 1632, YearOfDeath = 1675 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sanzio", LastName = "Raphael", YearOfBirth = 1483, YearOfDeath = 1520 });
            artists.Add(new Artist { Country = "Spain", FirstName = "Pablo", LastName = "Picasso", YearOfBirth = 1881, YearOfDeath = 1973 });
            artists.Add(new Artist { Country = "Norway", FirstName = "Edvard", LastName = "Munch", YearOfBirth = 1863, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Leonardo", LastName = "da Vinci", YearOfBirth = 1452, YearOfDeath = 1519 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sandro", LastName = "Botticelli", YearOfBirth = 1445, YearOfDeath = 1510 });
            artists.Add(new Artist { Country = "France", FirstName = "Henri", LastName = "Matisse", YearOfBirth = 1869, YearOfDeath = 1954 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Piet", LastName = "Mondrian", YearOfBirth = 1872, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "United States", FirstName = "Jackson", LastName = "Pollock", YearOfBirth = 1912, YearOfDeath = 1956 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Vincent", LastName = "van Gogh", YearOfBirth = 1853, YearOfDeath = 1890 });

            paintings = new List<Painting>();
            paintings.Add(new Painting { Artist = "van Gogh", Title = "The Starry Night", Method = "Oil on canvas", Year = 1889, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "van Gogh", Title = "Village Street in Auvers ", Method = "Oil on canvas", Year = 1890, Width = 73, Height = 92 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Gelee Blanche", Method = "Oil on canvas", Year = 1873, Width = 65, Height = 93 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Village Path", Method = "Oil on canvas", Year = 1875, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Fishing Boats Leaving the Harbor, Le Havre ", Method = "Oil on canvas", Year = 1874, Width = 60, Height = 101 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Water Lilies ", Method = "Oil on canvas", Year = 1906, Width = 88, Height = 93 });
            paintings.Add(new Painting { Artist = "Constable", Title = "The Leaping Horse", Method = "Oil on canvas", Year = 1825, Width = 142, Height = 187 });
            paintings.Add(new Painting { Artist = "Vermeer", Title = "Girl with a Pearl Earring", Method = "Oil on canvas", Year = 1665, Width = 45, Height = 40 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "Madonna dell Granduca ", Method = "Oil on wood", Year = 1505, Width = 84, Height = 55 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "St. George Fighting the Dragon ", Method = "Oil on wood", Year = 1825, Width = 28, Height = 21 });
            paintings.Add(new Painting { Artist = "Munch", Title = "The Scream", Method = "Tempera on paper", Year = 1893, Width = 91, Height = 74 });
            paintings.Add(new Painting { Artist = "da Vinci", Title = "The Last Supper", Method = "Tempera on plaster", Year = 1498, Width = 460, Height = 880 });
            paintings.Add(new Painting { Artist = "Botticelli", Title = "The Birth of Venus", Method = "Tempera on canvas", Year = 1485, Width = 173, Height = 280 });
            paintings.Add(new Painting { Artist = "Matisse", Title = "La Musique", Method = "Oil on canvas", Year = 1939, Width = 115, Height = 115 });
            paintings.Add(new Painting { Artist = "Mondrian", Title = "Composition with Red, Yellow and Blue", Method = "Oil on canvas", Year = 1821, Width = 40, Height = 35 });
            paintings.Add(new Painting { Artist = "Pollock", Title = "The Key", Method = "Oil on canvas", Year = 1946, Width = 84, Height = 213 });
            paintings.Add(new Painting { Artist = "Picasso", Title = "The Three Musicians", Method = "Oil on canvas", Year = 1921, Width = 200, Height = 222 });



        }

        //------------------------------------------------------
        // btnAllPaintings
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //print all paintings, one per line
            foreach (Painting painting in paintings)
            {
                listBox1.Items.Add(painting.ToString());
            }
        }


        //------------------------------------------------------
        // btnArtistsFromItaly
        //------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<Artist> italianArtists;           
            //find all artists from Italy
            italianArtists = artists.Where(a => a.Country == "Italy");

            //print each italian artist, one per line
            foreach (Artist artist in italianArtists)
            {
                listBox1.Items.Add(artist.ToString());
            }
        }

        //------------------------------------------------------
        // btnBefore1800
        //------------------------------------------------------
        private void btnBefore1800_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<Painting> pre1800;
            pre1800 = paintings.Where(a => a.Year < 1800)
                               .OrderBy(a => a.Year);

            foreach (Painting painting in pre1800)
            {
                listBox1.Items.Add(painting.ToString());
            }
        }

        //------------------------------------------------------
        // btnOldest
        //------------------------------------------------------
        private void btnOldest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Painting oldest;
            //order paintings by year, and return only the first (being the oldest)
            oldest = paintings.OrderBy(a => a.Year).First();

            listBox1.Items.Add(oldest.ToString());
        }

        //------------------------------------------------------
        // byThisArtist
        //------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {           
            listBox1.Items.Clear();

            //if the input is a reasonable string
            if(isValid(textBox1.Text))
            {
                IEnumerable<Painting> returnSearched;
                //search paintings for artists that contains the search string
                returnSearched = paintings.Where(a => a.Artist.ToLower().Contains(textBox1.Text.ToLower()));

                //print feedback if search returns no results
                if(returnSearched.Count() == 0)
                {
                    listBox1.Items.Add("No items found");
                }
                //otherwise, print results one per line
                else
                {
                    foreach (Painting painting in returnSearched)
                    {
                        listBox1.Items.Add(painting.ToString());
                    }
                }
            }
            //if search was invalid, give user a stern telling off
            else
            {
                listBox1.Items.Add("Invalid Search");
            }
        }

        /// <summary>
        /// checks given string for suspicious characters, returns true if string is clean
        /// </summary>
        /// <param name="stringInput"></param>
        /// <returns></returns>
        private bool isValid(string stringInput)
        {
            bool validSearch = Regex.IsMatch(stringInput, @"^[a-zA-Z ]+$");
            return validSearch;
        }

        //------------------------------------------------------
        // btnNbyCountry
        //------------------------------------------------------
        private void btnNbyCountry_Click(object sender, EventArgs e)
        {
            //TODO: Unsure how to order correctly

            listBox1.Items.Clear();

            //groups all paintings by the country their artist was from
            var paintingsOrigin = from painting in paintings
                                  join artist in artists
                                  on painting.Artist equals artist.LastName
                                  orderby painting.Year
                                  group artist by artist.Country;

            //for each different country grouping
            foreach (var record in paintingsOrigin)
            {
                //count how many paintings are contained
                int count = record.Count();

                //determine if the word 'painting', or 'paintings' should be used
                string paintingGrammatical;
                if (count == 1) paintingGrammatical = " painting "; //if there's only one painting
                else paintingGrammatical = " paintings "; //if there are 0 or many paintings

                string country = record.Key;

                listBox1.Items.Add(count + paintingGrammatical + "from " + country);
            }
        }

        //------------------------------------------------------
        // btnArtistGroupedByCountry
        //------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //group all artists by their country
            var groupedByCountry = from artist in artists                                   
                                   orderby artist.LastName
                                   orderby artist.Country
                                   group artist by artist.Country;

            //for each different country
            foreach (var group in groupedByCountry)
            {
                //print an identifying label
                String country = group.Key;
                listBox1.Items.Add(country + ":");

                //for each artist in the current country
                foreach (Artist artist in group)
                {
                    //print one per line
                    listBox1.Items.Add("\t\t" + artist.FirstName + " " + artist.LastName);
                }
            }        
        }

        //------------------------------------------------------
        // btnDutchPaintings
        //------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //returns all paintings painted by a dutch artist
            var dutchPaintings = from painting in paintings
                                 join artist in artists
                                 on painting.Artist equals artist.LastName
                                 orderby painting.Year
                                 where artist.Country == "Netherlands"
                                 select new { painting.Artist, painting.Year, painting.Method, painting.Title};

            foreach (var item in dutchPaintings)
            {
                listBox1.Items.Add(item.Artist + "\t\t" + item.Year + "\t" + item.Method + "\t" + item.Title);
            }
        }

        //------------------------------------------------------
        // btnJoinTables
        //------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //returns all paintings, with artist's full name and country.
            var all = from painting in paintings
                      join artist in artists
                      on painting.Artist equals artist.LastName
                      orderby painting.Title
                      orderby artist.LastName
                      select new { artist.FirstName, artist.LastName, artist.Country, painting.Title };

            foreach (var item in all)
            {
                listBox1.Items.Add(item.FirstName + " " + item.LastName + "\t\t" + item.Country + "\t\t\t" + item.Title);
            }
        }

        //------------------------------------------------------
        // btnFrenchOrItalian
        //------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //returns only paintings from french or italian artists
            var frenchOrItalian = from painting in paintings
                                  join artist in artists
                                  on painting.Artist equals artist.LastName
                                  orderby painting.Title
                                  orderby artist.LastName
                                  where artist.Country == "Italy" || artist.Country == "France"
                                  select new { artist.LastName, artist.Country, painting.Title };

            foreach (var item in frenchOrItalian)
            {
                listBox1.Items.Add(item.LastName + "\t\t" + item.Country + "\t\t" + item.Title);
            }
        }

 
    }
}

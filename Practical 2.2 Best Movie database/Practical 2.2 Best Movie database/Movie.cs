using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2._2_Best_Movie_database
{
    class Movie
    {
        public int Year { get; }
        public string Title { get; }
        public string Director { get; }

        public Movie(int year, string title, string director)
        {
            Year = year;
            Title = title;
            Director = director;
        }
    }
}

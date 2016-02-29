using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2._2_Best_Movie_database
{
    class MovieDatabase
    {
        Dictionary<int, Movie> database;
        
        public MovieDatabase()
        {
            database = new Dictionary<int, Movie>();
        }

        public bool Add(int year, string title, string director)
        {
            if (!database.ContainsKey(year))
            {
                Movie newMovie = new Movie(year, title, director);
                database.Add(year, newMovie);
                return true;
            }
            return false;
        }

        public bool Delete(int year)
        {            
            return database.Remove(year);
        }

        public Movie Find(int year)
        {
            if (database.ContainsKey(year))
            {
                return database[year];
            }
            return null;
        }

        public List<Movie> AsList()
        {           
            return database.Values.ToList();
        }
    }


}

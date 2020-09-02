using LAB_1___API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_1___API
{
    public class Movie
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public string Directed_by { get; set; }
        public string[] Stars { get; set; }
        public string Genre { get; set; }

        public static void IniciateTree(int grade)
        {
            if (Storage.Instance.Movies.Root != null) Storage.Instance.Movies.Root = null;
            Storage.Instance.Movies.Grade = grade;
            Storage.Instance.Movies.Comparer = IdComparison;
        }

        public static Comparison<Movie> IdComparison = delegate (Movie movie1, Movie movie2)
        {
            return movie1.Name.CompareTo(movie2.Name);
        };
    }
}

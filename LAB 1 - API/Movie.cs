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
    }
}

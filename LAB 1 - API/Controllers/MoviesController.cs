using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB_1___API.Helpers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LAB_1___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            Movie.IniciateTree(3);

            List<Movie> MovieTest = new List<Movie>();
            Movie movie = new Movie
            {
                Name = "DDD",
                Year = Convert.ToDateTime("20/05/2007"),
                Directed_by = "Delbert Serman",
                Stars = new string[] { "Helge Curreen", "Tim Peevor" },
                Genre = "Drama"
            };
            MovieTest.Add(movie);

            movie = new Movie
            {
                Name = "BBB",
                Year = Convert.ToDateTime("18/05/2003"),
                Directed_by = "Kariotta O'Duane	",
                Stars = new string[] { "Ansell Tunuy", "Cull Iacobetto" },
                Genre = "Adventure|Animation|Children|Fantasy|Musical|Romance"
            };
            MovieTest.Add(movie);

            movie = new Movie
            {
                Name = "AAA",
                Year = Convert.ToDateTime("28/02/2000"),
                Directed_by = "Elmer Shenfish",
                Stars = new string[] { "Aurelea Peverell", "Rosalynd Tasseler" },
                Genre = "Action|Adventure|Sci-Fi"
            };
            MovieTest.Add(movie);

            movie = new Movie
            {
                Name = "EEE",
                Year = Convert.ToDateTime("03/04/2012"),
                Directed_by = "	Shayla Johnstone",
                Stars = new string[] { "Geoff Beiderbeck", "Essie Dron" },
                Genre = "Horror|Thriller"
            };
            MovieTest.Add(movie);

            movie = new Movie
            {
                Name = "CCC",
                Year = Convert.ToDateTime("28/12/2013"),
                Directed_by = "Bartholemy Bloschke",
                Stars = new string[] { "Aili O'Spillane", "Carmelia Tenpenny" },
                Genre = "Drama"
            };
            MovieTest.Add(movie);

            for (int i = 0; i < MovieTest.Count; i++)
            {
                Storage.Instance.Movies.Insert(MovieTest[i]);
            }

            return MovieTest;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{traversal}")]
        public IEnumerable<Movie> Get(string traversal)
        {
            if(traversal=="inorden")
            {
                return Storage.Instance.Movies.ToInOrden();
            }
            if (traversal == "preorden")
            {
                return null;
            }
            if (traversal == "postorden")
            {
                return null;
            }
            return null;
        }

        // POST api/<MoviesController>
        [HttpPost]
        public string Post([FromBody] string grade)
        {
            return "EL GRADO ES " + Convert.ToString(grade);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

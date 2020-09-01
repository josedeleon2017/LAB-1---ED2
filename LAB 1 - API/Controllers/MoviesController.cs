using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            List<Movie> MovieTest = new List<Movie>();
            Movie movie1 = new Movie
            {
                Name = "Invincible",
                Year = Convert.ToDateTime("20/05/2007"),
                Directed_by = "Delbert Serman",
                Stars = new string[] { "Helge Curreen", "Tim Peevor" },
                Genre = "Drama"
            };
            MovieTest.Add(movie1);

            Movie movie2 = new Movie
            {
                Name = "All Dogs Go to Heaven 2",
                Year = Convert.ToDateTime("18/05/2003"),
                Directed_by = "Kariotta O'Duane	",
                Stars = new string[] { "Ansell Tunuy", "Cull Iacobetto" },
                Genre = "Adventure|Animation|Children|Fantasy|Musical|Romance"
            };
            MovieTest.Add(movie2);

            Movie movie3 = new Movie
            {
                Name = "Guardians of the Galaxy",
                Year = Convert.ToDateTime("28/02/2000"),
                Directed_by = "Elmer Shenfish",
                Stars = new string[] { "Aurelea Peverell", "Rosalynd Tasseler" },
                Genre = "Action|Adventure|Sci-Fi"
            };
            MovieTest.Add(movie3);

            return MovieTest;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{traversal}")]
        public string Get(string traversal)
        {
            if(traversal=="inorden")
            {
                return "Recorrido InOrden del árbol";
            }
            if (traversal == "preorden")
            {
                return "Recorrido PreOrden del árbol";
            }
            if (traversal == "postorden")
            {
                return "Recorrido PostOrden del árbol";
            }
            return "value";
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

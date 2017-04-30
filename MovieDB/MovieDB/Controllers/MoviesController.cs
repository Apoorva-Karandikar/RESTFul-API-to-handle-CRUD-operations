using MovieDB.Models;
using Newtonsoft.Json;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieDB.Controllers
{
    public class MoviesController : ApiController
    {
        static readonly IMovieRepository repository = new MovieRepository();
        
        [Route("movies")]
        [HttpGet]
        [SwaggerOperation("get-movies")]
        public List<Movie> ListAllMovies() {
            return repository.ListAllMovies();
        }
        
        [Route("movies/{id}")]
        [HttpGet]
        [SwaggerOperation("get-movies-by-id")]
        public Movie GetMovieById(string id) {
            return repository.GetMovieById(id);
        }

        [Route("movies")]
        [HttpPost]
        [SwaggerOperation("create-new-movie")]
        public void Post([FromBody]string jsonString) {
            var newMovie = JsonConvert.DeserializeObject<Movie>(jsonString);
            repository.Add(newMovie);
        }

        // PUT api/<controller>/5
        [Route("movies")]
        [HttpPut]
        [SwaggerOperation("update-existing-movie")]
        public bool Put([FromBody]string jsonString) {
            var updatedMovie = JsonConvert.DeserializeObject<Movie>(jsonString);
            return repository.UpdateMovie(updatedMovie);
        }

        // DELETE api/<controller>/5
        [Route("movies/{id}")]
        [HttpDelete]
        [SwaggerOperation("delete-existing-movie")]
        public void Delete(string id) {
            repository.DeleteMovie(id);
        }
    }
}
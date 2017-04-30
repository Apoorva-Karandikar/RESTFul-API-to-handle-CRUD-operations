using MovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.Models
{
    public interface IMovieRepository
    {
        List<Movie> ListAllMovies();
        Movie GetMovieById(string id);
        Movie Add(Movie item);
        bool UpdateMovie(Movie item);
        void DeleteMovie(string id);
    }
}

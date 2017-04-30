using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> movies = new List<Models.Movie>();
        public MovieRepository() {
            Add(
                new Movie() {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Fault In Our Stars",
                    Director = "Josh Boone",
                    ReleaseYear = 2014,
                    Rating = 7.8
                }
            );
            Add(
                new Movie() {
                    Id = Guid.NewGuid().ToString(),
                    Name = "A Walk To Remember",
                    Director = "Adam Shankman",
                    ReleaseYear = 2002,
                    Rating = 7.4
                }
            );
            Add(
                new Movie() {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Die Hard",
                    Director = "John McTiernan",
                    ReleaseYear = 1988,
                    Rating = 8.2
                }
            );
            Add(
                new Movie() {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Black Hawk Down",
                    Director = "Ridley Scott",
                    ReleaseYear = 2001,
                    Rating = 7.7
                }
            );
        }

        public Movie GetMovieById(string id) {
            return movies.Find(m => m.Id == id);
        }

        public List<Movie> ListAllMovies() {
            return movies;
        }

        public Movie Add(Movie item) {
            if (item == null) {
                throw new ArgumentNullException("item");
            }
            movies.Add(item);
            return item;
        }

        public bool UpdateMovie(Movie item) {
            if (item == null) {
                throw new ArgumentNullException("item");
            }
            int index = movies.FindIndex(m => m.Id == item.Id);
            if (index == -1) {
                return false;
            }
            movies.RemoveAt(index);
            movies.Add(item);
            return true;
        }

        public void DeleteMovie(string id) {
            movies.RemoveAll(m => m.Id == id);
        }
    }
}
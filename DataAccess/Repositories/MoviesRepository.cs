using BusinessLogic.DomainModels;
using BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Extensions;
using System;

namespace DataAccess.Repositories
{
    public class MoviesRepository : RepositoryBase<Models.Movie>, IMoviesRepository
    {
        public MoviesRepository(MoviesContext context) : base(context) { }

        public Movie Add(Movie movie)
        {
            var movieModel = new Models.Movie()
            {
                Name = movie.Name,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
            Create(movieModel);

            return movieModel.ToDomainModel();
        }

        public List<Movie> GetAll()
        {
            var movies = FindAll(false).ToList();

            var moviesDomain = movies.Select(x => x.ToDomainModel());
            return moviesDomain.ToList();
        }

        public List<Movie> findBy(string id)
        {
            List<Models.Movie> movies = FindByCondition(x => x.UserId == id, false).ToList();

            var moviesDomain = movies.Select(x => x.ToDomainModel());
            return moviesDomain.ToList();
        }
    }
}

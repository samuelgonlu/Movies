using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class MoviesService
    {
        private readonly IRepositoryManagerM _repositoryManagerm;

        public MoviesService(IRepositoryManagerM repositoryManagerm)
        {
            _repositoryManagerm = repositoryManagerm;
        }

        public List<DTO.Movie> GetUserMovies()
        {
            return _repositoryManagerm.Movies.GetAll().Select(x => new Movie()
            {
                Id = x.Id,
                Name = x.Name,
                Genre = x.Genre,
                UserId = x.UserId
            }).ToList();
        }

        public DTO.Movie AddUserMovie(DTO.Movie movie)
        {
            var domainMovie = new DomainModels.Movie()
            {
                Name = movie.Name,
                Genre = movie.Genre,
                UserId = movie.UserId
            };

            var dbMovie = _repositoryManagerm.Movies.Add(domainMovie);
            _repositoryManagerm.Save();
            return dbMovie.ToDTO();
        }
    }
}

using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IMoviesRepository
    {
        public List<DomainModels.Movie> GetAll();

        public List<DomainModels.Movie> findBy(string id);

        public DomainModels.Movie Add(DomainModels.Movie movie);
    }
}

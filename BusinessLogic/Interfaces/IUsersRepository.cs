using BusinessLogic.DomainModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IUsersRepository
    {
        public List<DomainModels.User> GetAll();
        public List<DomainModels.User> findBy(string email);
        public DomainModels.User Add(DomainModels.User user);
    }
}

using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class UsersService
    {
        private readonly IRepositoryManager _repositoryManager;
         
        public UsersService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }


        public List<User> GetUsers()
        {
            return _repositoryManager.Users.GetAll().Select(x => new User()
            {
                Email = x.Email,
                Name = x.Name,
                UserId = x.UserId
            }).ToList();

        }

        public User CreateUser(UserSession user)
        {

            //Valida que no exista
            List<DTO.User> listusers = new List<DTO.User>();
            listusers = _repositoryManager.Users.findBy(user.Email).Select(x => new User()
            {
                Email =x.Email,
                Name = x.Name,
                UserId = x.UserId
            }).ToList();
            var domainUser = new DomainModels.User();
            var dbUser = new DomainModels.User();
            if (listusers.Count() == 0)
            {
                domainUser = new DomainModels.User()
                {
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password
                };
                 dbUser = _repositoryManager.Users.Add(domainUser);
                _repositoryManager.Save();
            }
            return dbUser.ToDTO();

        }

    }
}

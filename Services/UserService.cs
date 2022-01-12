using MyHealth.Models;
using MyHealth.Repositories;

namespace MyHealth.Services
{
    public class UserService : GenericService<User, UserRepository>
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository repository)
            : base(repository)
        {
            _userRepository = repository;
        }

    }
}

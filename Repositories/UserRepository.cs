using MyHealth.Database;
using MyHealth.Models;

namespace MyHealth.Repositories
{
    public class UserRepository : GenericRepository<User, DataContext>
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}

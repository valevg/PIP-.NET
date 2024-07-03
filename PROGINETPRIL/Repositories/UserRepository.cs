using DOTENET.Repositories;
using Microsoft.EntityFrameworkCore;
using PROGINETPRIL.Models;
using PROGINETPRIL.Data;
namespace PROGINETPRIL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User updatedUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
        private readonly DbContext _dbContext;

        public UserRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
}

using System.Collections.Generic;
using PROGINETPRIL.Models;
using Microsoft.EntityFrameworkCore;
using PROGINETPRIL.Models;
using PROGINETPRIL.Data;
namespace DOTENET.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        User CreateUser(User newUser);
        User UpdateUser(User updatedUser);
        void DeleteUser(int id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(u => u.UserId == id);
        }

        public User CreateUser(User newUser)
        {
            _context.User.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User UpdateUser(User updatedUser)
        {
            _context.Entry(updatedUser).State = EntityState.Modified;
            _context.SaveChanges();
            return updatedUser;
        }

        public void DeleteUser(int id)
        {
            var user = _context.User.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
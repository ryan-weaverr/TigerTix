using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.Data.Entities;

namespace TigerTix.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly TigerTixContext _context;
        public UserRepository(TigerTixContext context)
        {
            _context = context;
        }

        public void SaveUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public IEnumerable<User> GetAllUsers()
        {
            var users = from u in _context.Users
                        select u;
            return users.ToList();
        }
        public User GetUsersByID(int userID)
        {
            var user = (from u in _context.Users
                        where u.Id == userID
                        select u).FirstOrDefault();
            return user;
        }
        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }

}

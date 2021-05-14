using FirstAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApplication.Services
{
    public class UserManager : IRepo<User>
    {
        private CompanyContext _context;

        public UserManager()
        {

        }
        public UserManager(CompanyContext context)
        {
            _context = context;
        }
        public void Add(User t)
        {
            _context.Users.Add(t);
            _context.SaveChanges();
        }

        public User Get(string uid)
        {
            User user = null;
            user = _context.Users.Where(u => u.UserId == uid).FirstOrDefault();
            return user;
        }

        public ICollection<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}

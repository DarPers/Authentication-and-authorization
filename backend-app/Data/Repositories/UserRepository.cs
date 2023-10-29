using Data.Interfaces;
using Models;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }

        public User GetByName(string name)
        {
            return _context.Users.FirstOrDefault(i => i.Username == name);
        }

        public bool Save()
        {
            int saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}

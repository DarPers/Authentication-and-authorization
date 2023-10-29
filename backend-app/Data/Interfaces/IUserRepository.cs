using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
        public User GetByName(string name);

        public void Add(User user);

        public bool Save();
    }
}

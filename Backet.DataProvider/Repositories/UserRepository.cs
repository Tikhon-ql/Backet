using Backet.DataProvider.Context;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public User? ReadByEmail(string email) => _context.Users.FirstOrDefault(u=>u.Email == email);
    }
}

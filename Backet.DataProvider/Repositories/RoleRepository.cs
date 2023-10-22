using Backet.DataProvider.Context;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models.Identity;

namespace Backet.DataProvider.Repositories
{
    internal class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

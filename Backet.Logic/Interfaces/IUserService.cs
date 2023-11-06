using Backet.Common.ViewModels.Users;
using Backet.Logic.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Logic.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetTopUsers(TopUsersFilterViewModel filterViewModel)
    }
}

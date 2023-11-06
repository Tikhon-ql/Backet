using Backet.Common.ViewModels.Users;
using Backet.DataProvider.Filters;
using Backet.DataProvider.Interfaces;
using Backet.Logic.Interfaces;
using Backet.Logic.Models;
using Backet.Logic.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.Logic.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserDto> GetTopUsers(TopUsersFilterViewModel filterViewModel)
        {
            var filter = new UserFilter
            {
                SortBy = filterViewModel.SortBy
            };
            if (filterViewModel.CurrentPage.HasValue)
                filter.CurrentPage = filterViewModel.CurrentPage.Value;
            if (filterViewModel.PageSize.HasValue)
                filter.PageSize = filterViewModel.PageSize.Value;
            if (filterViewModel.SortByAscend.HasValue)
                filter.SortByAscend = filterViewModel.SortByAscend.Value;
            var users = _userRepository.ReadByFilter(filter);
            var result = users.Select(u => new UserDto
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                Roles = u.Roles.Select(r => new RoleDto { RoleName = r.RoleName}).ToList(),
                Stats = u.Stats.Select(s=> new PlayStatsDto
                {
                    Id = s.Id,
                    Points = s.Points,
                    Steals = s.Steals,
                    Assists = s.Assists,
                    Rebounds = s.Rebounds
                }).ToList(),
            }).ToList();
            return result;
        }
    }
}

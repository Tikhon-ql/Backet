using Backet.Common.Interfaces;
using Backet.Common.ViewModels.Users;
using Backet.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backet.WebApi.Controllers
{
    [Route("/user")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUnitOfWork unitOfWork, IUserService userService) : base(unitOfWork)
        {
            _userService = userService;
        }

        [HttpGet("getTop")]
        public IActionResult GetTopUsers(TopUsersFilterViewModel filterViewModel)
        {
            var list = _userService.GetTopUsers(filterViewModel);
            return Ok(list);
        }
    }
}

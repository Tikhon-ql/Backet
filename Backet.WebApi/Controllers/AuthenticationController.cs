using Backet.Common.Interfaces;
using Backet.Common.ViewModels;
using Backet.Common.ViewModels.Identity;
using Backet.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backet.WebApi.Controllers
{
    [Route("/authentication")]
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService,IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginViewModel viewModel)
        {
            var tokenResult = _authenticationService.Login(viewModel);
            if (tokenResult.IsFailure)
                return BadRequest();
            return ReturnOk(tokenResult.Value);
        }
        [HttpPost("registration")]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            var result = _authenticationService.Register(viewModel);
            if(result.IsFailure)
                return BadRequest();
            return ReturnOk();
        }

        [HttpPost("refreshToken")]
        public IActionResult RefreshToken(RefreshTokenViewModel viewModel)
        {
            var tokenResult = _authenticationService.RefreshToken(viewModel);
            if (tokenResult.IsFailure)
                return BadRequest();
            return ReturnOk(tokenResult.Value);
        }


        [Authorize]
        [HttpGet("getcode")]
        public IActionResult GetInt()
        {
            return Ok(202);
        }
    }
}

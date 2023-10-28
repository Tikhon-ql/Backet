using Backet.Common.ViewModels;
using Backet.Logic.Models.Identity;
using ResultMonad;

namespace Backet.Logic.Interfaces
{
    public interface IAuthenticationService
    {
        Result<Token> Login(LoginViewModel viewModel);
        Result Register(RegisterViewModel viewModel);
        Result<Token> RefreshToken(RefreshTokenViewModel viewModel);
    }
}

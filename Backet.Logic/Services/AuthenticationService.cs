using Backet.Common.ViewModels;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models.Identity;
using Backet.Logic.Interfaces;
using Backet.Logic.Models.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ResultMonad;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Backet.Logic.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly IConfiguration _configuration;
        public AuthenticationService(IUserRepository userRepository, IRefreshTokenRepository refreshTokenRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _refreshTokenRepository = refreshTokenRepository;
            _configuration = configuration;
        }

        public Result<Token> Login(LoginViewModel viewModel)
        {
            var user = _userRepository.ReadByEmail(viewModel.Email);
            if (user == null)
                return Result.Fail<Token>();
            if (user.Password != viewModel.Password)
                return Result.Fail<Token>();

            return Result.Ok(GenerateToken(user));
        }

        private Token GenerateToken(User user)
        {

            var refreshToken = new RefreshToken
            {
                ExpirationDate = DateTime.UtcNow.AddDays(2),
                User = user,
                Token = GenerateRefreshToken()
            };

            _refreshTokenRepository.Create(refreshToken);

            var token = new Token
            {
                AccessToken = GenerateAccessToken(user),
                RefreshToken = refreshToken.Token,
            };
            return token;
        }

        private string GenerateAccessToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sid, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };

            //int accessTokenExpirationTimeInMinutes = int.Parse(_configuration["AccessTokenSettings:ExpirationTimeMin"]);

            var accessToken = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(accessToken);
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public Result Register(RegisterViewModel viewModel)
        {
            var user = _userRepository.ReadByEmail(viewModel.Email);
            if (user != null)
                return Result.Fail();
            var newUser = new User
            {
                Email = viewModel.Email,
                Roles = new List<Role> { new Role { RoleName = "User" } },
                Password = viewModel.Password,
            };
            _userRepository.Create(newUser);
            return Result.Ok();
        }

        private Result<JwtSecurityToken> ParseJwt(string jwtToken)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtSecurityToken;
                jwtSecurityToken = handler.ReadJwtToken(jwtToken);
                return Result.Ok(jwtSecurityToken);
            }
            catch (Exception ex)
            {
                return Result.Fail<JwtSecurityToken>();
            }
        }

        public Result<Token> RefreshToken(RefreshTokenViewModel viewModel)
        {
            var refreshToken = _refreshTokenRepository.ReadByToken(viewModel.RefreshToken);
            if (refreshToken == null)
                return Result.Fail<Token>();

            var jwtToken = ParseJwt(viewModel.AccessToken);
            if (jwtToken.IsFailure)
                return Result.Fail<Token>();

            var userId = jwtToken.Value.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.Sid);
            if (Guid.Parse(userId.Value) != refreshToken.User.Id)
                return Result.Fail<Token>();

            var isRefreshTokenExpired = refreshToken.ExpirationDate <= DateTime.UtcNow.AddMinutes(30);

            return Result.Ok(isRefreshTokenExpired ? GenerateToken(refreshToken.User) :
                new Token
                {
                    AccessToken = GenerateAccessToken(refreshToken.User),
                    RefreshToken = refreshToken.Token
                });
        }
    }
}

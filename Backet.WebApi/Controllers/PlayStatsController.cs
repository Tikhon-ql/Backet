using Backet.Common.Interfaces;
using Backet.Common.ViewModels.PlayStats;
using Backet.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Backet.WebApi.Controllers
{
    [Route("/playStats")]
    public class PlayStatsController : BaseController
    {
        private readonly IPlayStatsService _playStatsService;
        public PlayStatsController(IUnitOfWork unitOfWork, IPlayStatsService playStatsService) : base(unitOfWork)
        {
        }

        [Authorize]
        [HttpPost("addStats")]
        public IActionResult AddPlayStat(PlayStatAddingViewModel viewModel)
        {
            var userId = Guid.Parse(User.Claims.First(c=>c.Type == JwtRegisteredClaimNames.Sid).Value);
            _playStatsService.AddPlayStatToUser(userId, viewModel);
            return ReturnOk();
        }
        [Authorize("getStats")]
        public IActionResult GetStats(PlayStatsFilterViewModel filterViewModel)
        {
            var stats = _playStatsService.GetByFilter(filterViewModel);
            return Ok(stats);
        }
    }
}

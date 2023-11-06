using Backet.Common.ViewModels.PlayStats;
using Backet.DataProvider.Filters;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models;
using Backet.Logic.Interfaces;
using Backet.Logic.Models;

namespace Backet.Logic.Services
{
    internal class PlayStatsService : IPlayStatsService
    {
        private readonly IPlayStatsRepository _playStatRepository;

        public PlayStatsService(IPlayStatsRepository playStatRepository)
        {
            _playStatRepository = playStatRepository;
        }

        public void AddPlayStatToUser(Guid userId, PlayStatAddingViewModel viewModel)
        {
            var playStat = new PlayStats
            {
                Points = viewModel.Points,
                Rebounds = viewModel.Rebounds,
                Assists = viewModel.Assists,
                Steals = viewModel.Steals,
                UserId = userId,
            };
            _playStatRepository.Create(playStat);
        }

        public List<PlayStatsDto> GetByFilter(PlayStatsFilterViewModel filterViewModel)
        {
            var filter = new PlayStatsFilter
            {
                Begining = filterViewModel.Begining,
                Ending = filterViewModel.Ending,
            };
            if (filterViewModel.CurrentPage.HasValue)
                filter.CurrentPage = filterViewModel.CurrentPage.Value;
            if (filterViewModel.PageSize.HasValue)
                filter.PageSize = filterViewModel.PageSize.Value;

            var list = _playStatRepository.ReadByFilter(filter);
            var result = new List<PlayStatsDto>();
            result = list.Select(ps => new PlayStatsDto
            {
                Points = ps.Points,
                Rebounds = ps.Rebounds,
                Assists = ps.Assists,
                Steals = ps.Steals
            }).ToList();
            return result;
        }
    }
}

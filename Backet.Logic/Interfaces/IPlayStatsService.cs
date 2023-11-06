using Backet.Common.ViewModels.PlayStats;
using Backet.Logic.Models;

namespace Backet.Logic.Interfaces
{
    public interface IPlayStatsService
    {
        void AddPlayStatToUser(Guid userId, PlayStatAddingViewModel viewModel);
        List<PlayStatsDto> GetByFilter(PlayStatsFilterViewModel filterViewModel);
    }
}

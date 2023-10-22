using Backet.DataProvider.Context;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Repositories
{
    internal class PlayStatsRepository : BaseRepository<PlayStats>, IPlayStatsRepository
    {
        public PlayStatsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

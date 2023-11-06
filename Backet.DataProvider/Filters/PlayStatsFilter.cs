using Backet.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Filters
{
    public class PlayStatsFilter : BaseFilter<PlayStats>
    {
        public DateTime? Begining { get; set; }
        public DateTime? Ending { get; set; } = DateTime.Now;

        public override IQueryable<PlayStats> EnrichQuery(IQueryable<PlayStats> query)
        {
            if (Begining.HasValue && Ending.HasValue)
                query = query.Where(p => p.Date > Begining && p.Date < Ending);
            return base.EnrichQuery(query);
        }
    }
}

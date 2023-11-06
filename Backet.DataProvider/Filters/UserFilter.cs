using Backet.Common.Enums;
using Backet.DataProvider.Models.Identity;

namespace Backet.DataProvider.Filters
{
    public class UserFilter : BaseFilter<User>
    {
        public bool SortByAscend { get; set; } = true;
        public StatsType? SortBy { get; set; }

        public override IQueryable<User> EnrichQuery(IQueryable<User> query)
        {
            if (SortByAscend && SortBy.HasValue)
                query = query.OrderBy(b=>b.Stats.Select(s=> new { Value = (int)s.GetType().GetProperty(SortBy.Value.ToString()).GetValue(s)}).Sum(i=>i.Value));//Govno
            return base.EnrichQuery(query);
        }
    }
}

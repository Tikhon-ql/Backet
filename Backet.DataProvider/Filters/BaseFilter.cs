using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Filters
{
    public abstract class BaseFilter<T>
    {
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public virtual IQueryable<T> EnrichQuery(IQueryable<T> query)
        {
            query = query.Skip(CurrentPage * PageSize).Take(PageSize);
            return query;
        }
    }
}

using Backet.DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        T Read(Guid id);
        void Delete(T entity);
    }
}

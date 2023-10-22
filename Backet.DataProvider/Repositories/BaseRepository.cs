using Backet.DataProvider.Context;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Repositories
{
    internal class BaseRepository<T> : IDisposable, IRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entitySet;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entitySet = _context.Set<T>();
        }

        public void Create(T entity) => _context.Add(entity);

        public void Delete(T entity) => _context.Remove(entity);

        public void Dispose() => _context.Dispose();

        public T? Read(Guid id) => _entitySet.FirstOrDefault(e => e.Id == id);

        public List<T> ReadAll() => _entitySet.ToList();
    }
}

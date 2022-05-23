using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repositories
{
    public class Repositories<T> : IRepositories<T> where T : DbContext
    {
        private readonly MonterDataContext _context;

        public Repositories(MonterDataContext context)
        {
            _context = context;
            Skill a = new Skill();
            a.TypeSkill = TypeSkill.Damage ;
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }
    }
}

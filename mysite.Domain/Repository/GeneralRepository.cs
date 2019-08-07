using AllExpirience.Models;
using mysite.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysite.Domain.Repository
{
    public class GeneralRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private HelpDBContext _context;
        private DbSet<TEntity> _dbSet;


        public GeneralRepository(HelpDBContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity Entity)
        {
            if (Entity!=null)
            {
                _dbSet.Add(Entity);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

using _0_Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Infrastructure
{
    public class RepositoryBase<TKey, T> : IRepositoryBase<TKey, T> where T : class
    {

        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbContext.Add<T>(entity);
        }

        public void Edit(T entity)
        {
            _dbContext.Update<T>(entity);
        }

        public T Get(TKey id)
        {
           return _dbContext.Find<T>(id);
        }

        public List<T> GetAll()
        {
           return _dbContext.Set<T>().ToList(); 
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }
    }
}

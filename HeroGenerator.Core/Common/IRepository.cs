using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGenerator.Core.Common
{
    public interface IRepository
    {
        public void Add<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;
        public void Delete<T>(T entity) where T : class;
        public T GetById<T>(int id) where T : class;
        public IQueryable<T> GetAll<T>() where T : class;
        int SaveChanges();

    }
}

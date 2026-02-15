using HeroGenerator.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGenerator.Core.Common
{

    public class Repository(HeroGeneratorDbContext context) : IRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return context.Set<T>();
        }

        public T GetById<T>(int id) where T : class
        {
            T entity = context.Set<T>().Find(id)!;
            return entity;
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}

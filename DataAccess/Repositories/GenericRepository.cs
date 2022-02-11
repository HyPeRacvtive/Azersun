using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var c = new DataContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new DataContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new DataContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            using var c = new DataContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            using var c = new DataContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var c = new DataContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}

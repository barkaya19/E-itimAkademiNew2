using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new AppDbContext();
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new AppDbContext();
            c.Set<T>().Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new AppDbContext();
            c.Set<T>().Update(t);
        }
    }
}

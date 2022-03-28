using System.Collections.Generic;
using System.Data.Entity;

namespace Assignment4
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DbSet<T> table = null;
        public void Add(T item)
        {
            table.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Remove(T item)
        {
            table.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
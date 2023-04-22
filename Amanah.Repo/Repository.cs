using Amanah.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Amanah.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AmanahDbContext context;
        private DbSet<T> entities;

        public Repository(AmanahDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public  IEnumerable<T>  GetAllAsync()
        {
            return  entities.AsEnumerable();
        }
        public T Get(long id)
        {
            return entities.SingleOrDefault();
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
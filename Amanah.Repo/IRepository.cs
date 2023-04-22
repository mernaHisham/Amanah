namespace Amanah.Repo
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

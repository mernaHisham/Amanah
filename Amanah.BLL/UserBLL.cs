using Amanah.DAL.Models;
using Amanah.Interfaces;
using Amanah.Repo;

namespace Amanah.BLL
{
    public class UserBLL:IUserBLL
    {
        private readonly IRepository<User> _repo;
        public UserBLL(IRepository<User> repo)
        {
            _repo= repo;    
        }
        public User Login(string userName,string password)
        {
            return _repo.GetAll().
                FirstOrDefault(z => (z.Name == userName|| z.Mail == userName) && z.Password == password); 
        }
    }
}

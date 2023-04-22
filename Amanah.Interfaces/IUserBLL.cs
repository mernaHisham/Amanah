using Amanah.DAL.Models;

namespace Amanah.Interfaces
{
    public interface IUserBLL
    {
        User Login(string userName, string password);
    }
}

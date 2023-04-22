using Amanah.DAL.Models;
using Amanah.Repo;
using Amanah.BLL;
using Amanah.Interfaces;

namespace Amanah.api.Services
{
    public static class Installer
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository<Invoice>, Repository<Invoice>>();
            services.AddTransient<IInvoiceBLL, InvoiceBLL>();

            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IUserBLL, UserBLL>();
        }
    }
}

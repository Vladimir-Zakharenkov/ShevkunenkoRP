using Microsoft.EntityFrameworkCore;
using Site.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Services
{
    public class SQLAdminAccessRepository : IAdminAccessRepository
    {
        private readonly SiteContext _siteContext;
        public SQLAdminAccessRepository(SiteContext siteContext) => _siteContext = siteContext;

        public AdminAccess GetAdmin(AdminAccess model)
        {
            return _siteContext.AdminAccess.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
        }
    }
}

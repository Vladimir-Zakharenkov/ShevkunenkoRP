using Site.Models;
using System.Threading.Tasks;

namespace Site.Services
{
    public interface IAdminAccessRepository
    {
        AdminAccess GetAdmin(AdminAccess model);
    }
}
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EFCore
{
    public class EFAdminRepository : GenericRepository<Admin>, IAdminDal
    {
    }
}

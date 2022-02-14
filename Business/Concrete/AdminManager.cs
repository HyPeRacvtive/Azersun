using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void Add(Admin t)
        {
            _admindal.Insert(t);
        }

        public void Delete(Admin t)
        {
            _admindal.Delete(t);
        }

        public Admin GetById(int id)
        {
            return _admindal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _admindal.GetListAll();
        }

        public List<Admin> GetListById(int id)
        {
            return _admindal.GetListAllById(x => x.Id == id);
        }

        public void Update(Admin t)
        {
            _admindal.Update(t);
        }
    }
}

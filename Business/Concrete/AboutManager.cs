using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _about;

        public AboutManager(IAboutDal about)
        {
            _about = about;
        }

        public void Add(About t)
        {
            _about.Insert(t);
        }

        public void Delete(About t)
        {
            _about.Delete(t);
        }

        public About GetById(int id)
        {
            return _about.GetById(id);
        }

        public List<About> GetList()
        {
            return _about.GetListAll();
        }

        public List<About> GetListById(int id)
        {
            return _about.GetListAll(x => x.Id == id);
        }

        public void Update(About t)
        {
            _about.Update(t);
        }
    }
}

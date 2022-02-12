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

        public void AboutUpdate(About about)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetListAll()
        {
            return _about.GetListAll();
        }
    }
}

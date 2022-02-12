using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void AboutUpdate(About about);
        List<About> GetListAll();
    }
}

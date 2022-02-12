using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SettingManager : ISettingService
    {
        ISettingDal _setting;

        public SettingManager(ISettingDal setting)
        {
            _setting = setting;
        }

        public List<Settings> GetListAll()
        {
            return _setting.GetListAll();
        }


        public void SettingUpdate(Settings setting)
        {
            throw new System.NotImplementedException();
        }
    }
}

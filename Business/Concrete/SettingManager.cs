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

        public void Add(Settings t)
        {
            _setting.Insert(t);
        }

        public void Delete(Settings t)
        {
            _setting.Delete(t);
        }

        public Settings GetById(int id)
        {
            return _setting.GetById(id);
        }

        public List<Settings> GetList()
        {
            return _setting.GetListAll();
        }

        public List<Settings> GetListById(int id)
        {
            return _setting.GetListAll(x => x.Id == id);
        }

        public void Update(Settings t)
        {
            _setting.Update(t);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialmedia;

        public SocialMediaManager(ISocialMediaDal socialmedia)
        {
            _socialmedia = socialmedia;
        }

        public void Add(SocialMedia t)
        {
            _socialmedia.Insert(t);
        }

        public void Delete(SocialMedia t)
        {
            _socialmedia.Delete(t);
        }

        public SocialMedia GetById(int id)
        {
            return _socialmedia.GetById(id);
        }

        public List<SocialMedia> GetList()
        {
            return _socialmedia.GetListAll();
        }

        public List<SocialMedia> GetListById(int id)
        {
            return _socialmedia.GetListAll(x => x.Id == id);
        }

        public void Update(SocialMedia t)
        {
            _socialmedia.Update(t);
        }
    }
}

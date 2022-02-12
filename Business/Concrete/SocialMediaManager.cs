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

        public List<SocialMedia> GetListAll()
        {
            return _socialmedia.GetListAll();
        }

        public void SocialUpdate(SocialMedia social)
        {
            throw new System.NotImplementedException();
        }
    }
}

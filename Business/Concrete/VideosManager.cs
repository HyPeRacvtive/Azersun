using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VideosManager : IVideosService
    {
        IVideosDal _videodal;

        public VideosManager(IVideosDal videodal)
        {
            _videodal = videodal;
        }

        public Videos GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Videos> GetListAll()
        {
            return _videodal.GetListAll();
        }

        public void VideoAdd(Videos slider)
        {
            throw new NotImplementedException();
        }

        public void VideoDelete(Videos slider)
        {
            throw new NotImplementedException();
        }

        public void VideoUpdate(Videos slider)
        {
            throw new NotImplementedException();
        }
    }
}

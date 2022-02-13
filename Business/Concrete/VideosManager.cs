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

        public void Add(Videos t)
        {
            _videodal.Insert(t);
        }

        public void Delete(Videos t)
        {
            _videodal.Delete(t);
        }

        public Videos GetById(int id)
        {
            return _videodal.GetById(id);
        }

        public List<Videos> GetList()
        {
            return _videodal.GetListAll();
        }

        public List<Videos> GetListById(int id)
        {
            return _videodal.GetListAll(x => x.Id == id);
        }

        public void Update(Videos t)
        {
            _videodal.Update(t);
        }
    }
}

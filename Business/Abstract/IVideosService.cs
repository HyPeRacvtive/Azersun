using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IVideosService
    {
        void VideoAdd(Videos slider);
        void VideoDelete(Videos slider);
        void VideoUpdate(Videos slider);
        List<Videos> GetListAll();
        Videos GetById(int id);
    }
}

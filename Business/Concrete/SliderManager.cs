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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public Sliders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sliders> GetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public void SliderAdd(Sliders slider)
        {
            throw new NotImplementedException();
        }

        public void SliderDelete(Sliders slider)
        {
            throw new NotImplementedException();
        }

        public void SliderUpdate(Sliders slider)
        {
            throw new NotImplementedException();
        }
    }
}

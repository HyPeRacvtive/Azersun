using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Sliders t)
        {
            _sliderDal.Insert(t);
        }

        public void Delete(Sliders t)
        {
            _sliderDal.Delete(t);
        }

        public Sliders GetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public List<Sliders> GetList()
        {
            return _sliderDal.GetListAll();
        }

        public List<Sliders> GetListById(int id)
        {
            return _sliderDal.GetListAllById(x => x.Id == id);
        }

        public void Update(Sliders t)
        {
            _sliderDal.Update(t);
        }
    }
}

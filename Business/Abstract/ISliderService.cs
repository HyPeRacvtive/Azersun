using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISliderService
    {
        void SliderAdd(Sliders slider);
        void SliderDelete(Sliders slider);
        void SliderUpdate(Sliders slider);
        List<Sliders> GetListAll();
        Sliders GetById(int id);
    }
}

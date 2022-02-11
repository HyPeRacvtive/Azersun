using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product product);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);
        List<Product> GetListAll();
        Product GetById(int id);


    }
}

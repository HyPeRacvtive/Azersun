using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _categorydal;

        public ProductManager()
        {
            _categorydal = new EFProductRepository();
        }

        public ProductManager(IProductDal categorydal)
        {
            _categorydal = categorydal;
        }

        public Product GetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _categorydal.GetListAll();
        }

        public void ProductAdd(Product product)
        {
            _categorydal.Insert(product);
        }

        public void ProductDelete(Product product)
        {
            _categorydal.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _categorydal.Update(product);
        }
    }
}

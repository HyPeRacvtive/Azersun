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
        IProductDal _productdal;

        public ProductManager()
        {
            _productdal = new EFProductRepository();
        }

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public Product GetById(int id)
        {
            return _productdal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _productdal.GetListAll();
        }

        public void ProductAdd(Product product)
        {
            _productdal.Insert(product);
        }

        public void ProductDelete(Product product)
        {
            _productdal.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productdal.Update(product);
        }
    }
}

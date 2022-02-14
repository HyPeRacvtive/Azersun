using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Product> GetList()
        {
            return _productdal.GetListAll().OrderByDescending(x => x.Id).ToList();
        }

        public void Add(Product t)
        {
            _productdal.Insert(t);
        }

        public void Delete(Product t)
        {
            _productdal.Delete(t);
        }

        public void Update(Product t)
        {
            _productdal.Update(t);
        }

        public List<Product> GetListById(int id)
        {
            return _productdal.GetListAllById(x => x.Id == id);
        }
    }
}

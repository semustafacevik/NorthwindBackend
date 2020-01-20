using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int productID)
        {
            return _productDal.Get(p => p.ProductID == productID);
        }

        public IList<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public IList<Product> GetListByCategoryId(int categoryID)
        {
            return _productDal.GetList(p => p.CategoryID == categoryID);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

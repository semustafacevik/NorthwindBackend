using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int productID);
        IList<Product> GetList();
        IList<Product> GetListByCategoryId(int categoryID);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}

using Northwind.Core.Utilities.Results;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetByID(int productID);
        IDataResult<IList<Product>> GetList();
        IDataResult<IList<Product>> GetListByCategoryID(int categoryID);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}

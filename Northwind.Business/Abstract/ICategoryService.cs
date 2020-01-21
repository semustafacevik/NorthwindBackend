using Northwind.Core.Utilities.Results;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetByID(int categoryID);
        IDataResult<IList<Category>> GetList();
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}

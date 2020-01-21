using Northwind.Core.DataAccess.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using Northwind.DataAccess.Abstract;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}

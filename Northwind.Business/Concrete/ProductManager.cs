﻿using Northwind.Business.Abstract;
using Northwind.Business.BusinessAspects;
using Northwind.Business.Constants;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Core.Aspects.Autofac.Caching;
using Northwind.Core.Aspects.Autofac.Performance;
using Northwind.Core.Aspects.Autofac.Validation;
using Northwind.Core.Utilities.Results;
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

        [ValidationAspect(typeof(ProductValidator), Priority = 1)]
        [CacheRemoveAspect(Pattern: "IProductService.Get")]
        [CacheRemoveAspect(Pattern: "ICategoryService.Get")]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetByID(int productID)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == productID));
        }

        [PerformanceAspect(3)]
        public IDataResult<IList<Product>> GetList()
        {
            System.Threading.Thread.Sleep(3000);
            return new SuccessDataResult<IList<Product>>(_productDal.GetList().ToList());
        }

        [SecuredOperation("Product.List,Admin")]
        [CacheAspect(Duration: 1)]
        public IDataResult<IList<Product>> GetListByCategoryID(int categoryID)
        {
            return new SuccessDataResult<IList<Product>>(_productDal.GetList(p => p.CategoryID == categoryID));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}

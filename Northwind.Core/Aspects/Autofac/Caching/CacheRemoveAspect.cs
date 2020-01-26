using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Core.CrossCuttingConcerns.Caching;
using Northwind.Core.Utilities.Interceptors.Autofac;
using Northwind.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;
        public CacheRemoveAspect(string Pattern)
        {
            _pattern = Pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}

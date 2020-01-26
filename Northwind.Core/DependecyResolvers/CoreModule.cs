using Microsoft.Extensions.DependencyInjection;
using Northwind.Core.CrossCuttingConcerns.Caching;
using Northwind.Core.CrossCuttingConcerns.Caching.Microsoft;
using Northwind.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Core.DependecyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}

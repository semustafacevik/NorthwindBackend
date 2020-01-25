using Microsoft.Extensions.DependencyInjection;
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
        }
    }
}

using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AspnetDiSample
{
    public class HandlerResolver
    {
        private IServiceScopeFactory _scopeFactory;

        public HandlerResolver(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public IEnumerable<IHandler> GetHandlers()
        {
            return _scopeFactory.CreateScope().ServiceProvider.GetServices<IHandler>();
        }
    }
}

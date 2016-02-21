using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace AspnetDiSample
{
    public interface IService
    {
        void Start();
    }

    public class Service : IService
    {
        private readonly IEnumerable<IHandler> _handlers;

        public Service(HandlerResolver handlers)
        {
            _handlers = handlers.GetHandlers();
            handlers.GetHandlers();
        }

        public void Start()
        {
            foreach (var handler in _handlers)
                handler.Handle();
        }
    }

    internal static class ServiceExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<IService, Service>();
            return services;
        }
    }
}

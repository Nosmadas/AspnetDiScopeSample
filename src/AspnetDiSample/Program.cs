using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace AspnetDiSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());

            IServiceCollection services = new ServiceCollection();
            services.AddService();
            services.AddHandlers();
            services.AddRepositories();
            services.AddUnitOfWork();
            services.AddScoped<Context>();
            services.AddTransient<HandlerResolver>();

            var provider = services.BuildServiceProvider();

            var serviceA = provider.GetService<IService>();
            serviceA.Start();
            serviceA.Start();

            Console.ReadLine();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace AspnetDiSample
{
    public interface IUnitOfWork { }

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(Context context)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }
    }

    public static class UnitOfWorkExtensions
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

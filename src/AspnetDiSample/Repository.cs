using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace AspnetDiSample
{
    public interface IUserRepository { }
    public interface IGroupRepository { }
    public interface IDeviceRepository { }

    public class UserRepository : IUserRepository
    {
        public UserRepository(Context context)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }
    }

    public class GroupRepository: IGroupRepository
    {
        public GroupRepository(Context context)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }
    }

    public class DeviceRepository : IDeviceRepository
    {
        public DeviceRepository(Context context)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }
    }

    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            return services;
        }
    }
}

using System;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace AspnetDiSample
{
    public interface IHandler
    {
        void Handle();
    }

    public class UserHandler : IHandler
    {
        public UserHandler(IUserRepository userRepo, IUnitOfWork uow)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }

        public void Handle()
        {
        }
    }

    public class DeviceHandler : IHandler
    {
        public DeviceHandler(IDeviceRepository deviceRepo, IUnitOfWork uow)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }

        public void Handle()
        {
        }
    }
    public class GroupHandler : IHandler
    {

        public GroupHandler(IUserRepository userRepo, IGroupRepository groupRepo, IUnitOfWork uow)
        {
            Trace.WriteLine($"Created { this.GetType().Name }");
        }

        public void Handle()
        {
        }
    }

    internal static class HandlerExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<IHandler, UserHandler>();
            services.AddTransient<IHandler, DeviceHandler>();
            services.AddTransient<IHandler, GroupHandler>();
            return services;
        }
    }

}



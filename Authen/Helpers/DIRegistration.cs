using Microsoft.Extensions.DependencyInjection;
using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.FactoryExecutions;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedService;

namespace Authen.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class DIRegistration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterFactory(services);
            RegisterBusinessServices(services);
        }

        /// <summary>
        /// Register All Factorys for DI
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterFactory(IServiceCollection services)
        {
            services.AddScoped<IEventFactory, EventFactory>();
            services.AddScoped<IGuestInfoFactory, GuestInfoFactory>();
            services.AddScoped<IGuestInfoServiceTypeFactory, GuestInfoServiceTypeFactory>();
            services.AddScoped<IServiceTypeFactory, ServiceTypeFactory>();
        }

        /// <summary>
        /// Register All Business Services for DI
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterBusinessServices(IServiceCollection services)
        {
            services.AddScoped<IGuestInfoService, GuestInfoService>((ctx) =>
            {
                IGuestInfoFactory factory = ctx.GetService<IGuestInfoFactory>();
                return new GuestInfoService(factory);
            });

            services.AddScoped<IGuestInfoServiceTypeService, GuestInfoServiceTypeService>((ctx) =>
            {
                IGuestInfoServiceTypeFactory factory = ctx.GetService<IGuestInfoServiceTypeFactory>();
                return new GuestInfoServiceTypeService(factory);
            });

            services.AddScoped<IEventService, EventService>((ctx) =>
            {
                IEventFactory factory = ctx.GetService<IEventFactory>();
                return new EventService(factory);
            });

            services.AddScoped<IServiceTypeService, ServiceTypeService>((ctx) =>
            {
                IServiceTypeFactory factory = ctx.GetService<IServiceTypeFactory>();
                return new ServiceTypeService(factory);
            });
        }
    }
}

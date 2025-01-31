using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HRM.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(MappingProfile)); // for one profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // register all profile with assembly
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}

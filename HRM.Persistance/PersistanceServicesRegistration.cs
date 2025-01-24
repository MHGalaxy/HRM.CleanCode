using HRM.Application.Contracts.Persistance;
using HRM.Persistance.Contexts;
using HRM.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HRM.Persistance
{
    public static class PersistanceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HrmDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LeaveManagementConnectionString"));
            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

            return services;
        }
    }
}

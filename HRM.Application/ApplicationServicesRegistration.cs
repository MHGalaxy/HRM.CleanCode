using HRM.Application.Contracts.Persistance;
using HRM.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HRM.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(MappingProfile)); // for one profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // register all profile with assembly
            //services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
        }
    }
}

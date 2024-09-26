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
        public static void ConfigureApplicationServices(IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(MappingProfile)); // for one profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // register all profile with assembly
        }
    }
}

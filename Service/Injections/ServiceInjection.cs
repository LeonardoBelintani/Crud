using Microsoft.Extensions.DependencyInjection;
using Service;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Injections
{
    public static class ServiceInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}

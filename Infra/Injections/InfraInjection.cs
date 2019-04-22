using Infra.Contexts;
using Infra.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Injections
{
    public static class InfraInjection
    {
        public static void AddSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ISqlServerContext, SqlServerContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        } 
    }
}

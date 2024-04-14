using ITD.MiDiario.Application.Interfaces;
using ITD.MiDiario.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.MiDiario.Infrastructure
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAuthentication("BasicAuthentication")
            //                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddScoped<IEventosRepositoryContext, EventosRepositoryContext>();
            return services;
        }
    }
}

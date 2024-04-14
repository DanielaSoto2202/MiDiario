using ITD.MiDiario.Application.Interfaces;
using ITD.MiDiario.Application.Interfaces.Context;
using ITD.MiDiario.Application.Presenters;
using ITD.MiDiario.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.MiDiario.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAuthentication("BasicAuthentication")
            //                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            _ = services.AddScoped<IEventosContext, EventosContext>();
            return services;
        }
    }
}

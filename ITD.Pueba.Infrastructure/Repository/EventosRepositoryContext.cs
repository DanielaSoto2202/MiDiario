using ITD.MiDiario.Application.Interfaces;
using ITD.MiDiario.Application.Interfaces.Context;
using ITD.MiDiario.Infrastructure.Context;
using ITD.MiDiario.Infrastructure.Services;
using Microsoft.Extensions.Configuration;


namespace ITD.MiDiario.Infrastructure.Repository
{
    public class EventosRepositoryContext: IEventosRepositoryContext
    {
        private readonly BDServices _bd;

        public EventosRepositoryContext(IConfiguration configuration)
        {
            _bd = new BDServices(configuration);
        }
       public IEventosContext EventosContext => new EventosContext(_bd);

    }
}

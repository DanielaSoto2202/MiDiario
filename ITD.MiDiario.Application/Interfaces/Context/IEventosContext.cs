

using ITDMiDiario.Domain.POCOS.Context;

namespace ITD.MiDiario.Application.Interfaces.Context
{
    public interface IEventosContext
    {
        public Task<List<EntityEventosContext>> Get(string clave);


    }
}

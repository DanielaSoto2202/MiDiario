using ITD.MiDiario.Application.Interfaces;
using ITD.MiDiario.Application.NewFolder;
using ITDMiDiario.Domain.DTO.DATA;
using ITDMiDiario.Domain.DTO.Response;
using ITDMiDiario.Domain.DTO.Response.DATA.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.MiDiario.Application.Presenters
{
    public class EventosPresenter : IEventosPresenter
    {
        private object _;

        private readonly IEventosRepositoryContext ;

           

        public async ValueTask<EventosResponse> Get(string nombre, string fecha, string hora, string ubicacion, string descripcion)
        {
            var beca = await _.EventosContext.Get(nombre, fecha, hora, ubicacion, descripcion);
            //List<EventosData> dT0s = _mapper.Map<List<EventosData>>(nombre);
            return new EventosResponse() { data = new EventosData() { attributes = dT0s, Type = "nombre" } };
        }
        public Task<object?> GetType(string nombre, string fecha, string hora, string ubicacion, string descripcion)
        {
            throw new NotImplementedException();
        }

        Task<List<EventosAttributes>> IEventosPresenter.Get(string nombre, string fecha, string hora, string ubicacion, string descripcion)
        {
            throw new NotImplementedException();
        }

        Task<List<EventosResponse>> IEventosPresenter.Get(string nombre, string fecha, string hora, string ubicacion, string descripcion)
        {
            throw new NotImplementedException();
        }
    }
}

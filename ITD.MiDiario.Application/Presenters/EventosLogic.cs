
using ITD.MiDiario.Application.Interfaces;
using ITDMiDiario.Domain.DTO;
using ITDMiDiario.Domain.DTO.Response.DATA.Attributes;
using ITDMiDiario.Domain.POCOS.Context;

namespace ITD.MiDiario.Application.Presenters
{
    public class EventosLogic
    {
        public EventosLogic(IEventosRepositoryContext iEventosRepositoryContext)
        {
            IEventosRepositoryContext = iEventosRepositoryContext;
            { 
        public List<EventosAttributes> GetEventos()
        {
            List<EntityEventosContext> eventos = new()// IEventosRepositoryContext.GetEventos();
            List<EventosAttributes> eventosAttributes = new List<EventosAttributes>();

            foreach (var evento in eventos)
            {
                eventosAttributes.Add(new EventosAttributes
                {
                    nombre = evento.nombre,
                    fecha = evento.fecha,
                    hora = evento.hora,
                    ubicacion = evento.ubicacion,
                    descripcion = evento.descripcion
                });
                

        }
            return eventosAttributes;
    }
}
        }Interfaz



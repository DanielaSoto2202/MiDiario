using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITDMiDiario.Domain.DTO.Response
{
    public class EventosResponse
    {
        // Propiedades de la clase EventosResponse
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
    }

    public interface IEventosPresenter
    {
        // Método para obtener una lista de EventosResponse
        Task<List<EventosResponse>> Get(string nombre, string fecha, string hora, string ubicacion, string descripcion);
    }
}

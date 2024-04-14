using ITDMiDiario.Domain.DTO.Response.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDMiDiario.Domain.POCOS.Context
{
    public class EntityEventosContext
    {
        public EventosData data;

        public int code { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
    }
}

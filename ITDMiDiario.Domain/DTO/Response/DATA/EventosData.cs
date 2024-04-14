using ITDMiDiario.Domain.DTO.Response.DATA.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDMiDiario.Domain.DTO.Response.DATA
{
    public class EventosData
    {
        public int id { get; set; }
        public required List<EventosAttributes> attributes { get; set; }
        public string Type { get; set; }

        //public static implicit operator EventosData(EventosData v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

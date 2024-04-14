using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDMiDiario.Domain.POCOS.Context
{
    public class EntifyEmocionesContext
    {
        public string emocion_experimentada { get; set; }
        public string descripcion { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

    }
}

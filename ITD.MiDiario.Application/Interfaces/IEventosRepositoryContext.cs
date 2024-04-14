using ITD.MiDiario.Application.Interfaces.Context;
using ITDMiDiario.Domain.POCOS.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.MiDiario.Application.Interfaces
{
   public interface IEventosRepositoryContext
    {
       public IEventosContext EventosContext { get; }
    }
}

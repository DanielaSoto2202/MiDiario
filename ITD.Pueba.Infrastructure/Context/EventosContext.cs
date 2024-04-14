using Dapper;
using ITD.MiDiario.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ITD.MiDiario.Infrastructure.Services;
using ITD.MiDiario.Application.Interfaces.Context;
using ITDMiDiario.Domain.POCOS.Context;
using System.Reflection.Metadata;

namespace ITD.MiDiario.Infrastructure.Context
{
    public class EventosContext : IEventosContext
    {
        private readonly BDServices _bDservices;

        public EventosContext(BDServices services)
        {
            _bDservices = services;
        }


        public async Task<List<EntityEventosContext>> Get(string clave)
        {
            DynamicParameters dp = new ();
            dp.Add("@clave", clave, System.Data.DbType.String);
            var result = await _bDservices.ExecuteStoredProcedureQuery<EntityEventosContext>("Eventos_GET", dp);
            List<EntityEventosContext> eventos = result.ToList();
            if(eventos.Count > 0)
            { 
            switch (eventos.First().code)
            {
                case 200 : {return eventos; }
                    case 404 : return new List<EntityEventosContext>();
                default: return new List<EntityEventosContext>();
            }
            }

            return new List<EntityEventosContext>();
        }
    }
}



using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mime;
using ITD.MiDiario.Application.Presenters;

namespace MiDiario.Controllers
{
    [Authorize]
    [Route("/[controller]")]
    [ApiController]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]

    public class EventosController : ControllerBase
    {
        private readonly EventosPresenter _eventosPresenter;

        public EventosController(EventosPresenter eventosPresenter)
        {
            _eventosPresenter = eventosPresenter;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<EventosResponse>), (int)IStatusCodeHttpResult.ok)]
        [ProducesResponseType(typeof(ErrorResponse>), (int)IStatusCodeHttpResult.badRequest)]

            public async Task<IActionResult> Get(string nombre, string fecha, string hora, string ubicacion, string descripcion)
        {
            return Ok(value: await _eventosPresenter.GetType(nombre, fecha, hora, ubicacion, descripcion));
        }
    }

}


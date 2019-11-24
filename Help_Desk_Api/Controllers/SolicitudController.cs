using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.ISolicitud;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Model;

namespace Help_Desk_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudService _serviceSolicitud;

        public SolicitudController(ISolicitudService service)
        {
            _serviceSolicitud = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceSolicitud.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetSolicitud/{id}")]
        public async Task<IActionResult> GetSolicitud(int? Id)
        {
            var result = await _serviceSolicitud.GetSolicitd(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetSolicitudEstado/{Estado}")]
        public async Task<IActionResult> GetSolicitudEstado(string Estado)
        {
            var result = await _serviceSolicitud.GetSolicitudEstado(Estado);
            return Ok(result);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> CrearSolicitud(Solicitud solicitud)
        {
            var result = await _serviceSolicitud.Agregar(solicitud);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Eliminar/{Id}")]
        public async Task<IActionResult> Eliminar(int? Id)
        {
            var result = await _serviceSolicitud.Eliminar(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar(Solicitud solicitud)
        {
            var result = await _serviceSolicitud.Editar(solicitud);
            return Ok(result);
        }



    }
}
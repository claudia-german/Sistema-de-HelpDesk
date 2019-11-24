using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.RolService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Model;

namespace Help_Desk_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;

        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _rolService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetRol")]
        public async Task<IActionResult> GetRol(int? IdRol)
        {
            var result = await _rolService.GetRol(IdRol);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRol")]
        public async Task<IActionResult> AddRol(Rol rol)
        {
            var result = await _rolService.Agregar(rol);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateRol")]
        public async Task<IActionResult> EditRol(Rol rol)
        {
            var result = await _rolService.Editar(rol);
            return Ok(result);
        }

    }
}
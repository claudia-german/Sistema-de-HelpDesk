using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.IUsuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Model;

namespace Help_Desk_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsuariosController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _userService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetUser/{Id}")]
        public async Task<IActionResult> GetUser(int? Id)
        {
            var result = await _userService.GetUser(Id);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Usuario user)
        {
            var result = await _userService.Editar(user);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Crear(Usuario user)
        {
            var result = await _userService.Agregar(user);
            return Ok(result);
        }
    }
}
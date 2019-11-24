using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.ILogin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Persistence.Model;

namespace Help_Desk_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService service)
        {
            _loginService = service;
        }

        [HttpGet]
        [Route("GetRol/{IdUsuario}")]
        public async Task<IActionResult> GetRol(int? IdUsuario)
        {
            var result = await _loginService.GetRol(IdUsuario);
            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Login  login)
        {
            var result = await _loginService.Login(login);
            return Ok(result);
        }

    }
}
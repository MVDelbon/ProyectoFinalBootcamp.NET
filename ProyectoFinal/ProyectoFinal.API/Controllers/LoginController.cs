using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Models.UsuarioSalon;
using ProyectoFinal.Application.Services.Interfaces;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly IUsuarioSalonServices _usuarioSalonService;

        public LoginController(IUsuarioSalonServices usuarioSalonService)
        {
            _usuarioSalonService = usuarioSalonService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequestModel loginRequest)
        {
            var response = _usuarioSalonService.Login(loginRequest);
            if (response == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            return Ok(response);
        }
    }
}

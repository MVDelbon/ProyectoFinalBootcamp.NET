using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Models.UsuarioSalon;
using ProyectoFinal.Application.Services.Interfaces;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioSalonController : ControllerBase
    {
        public readonly IUsuarioSalonServices _usuarioSalonService;

        public UsuarioSalonController(IUsuarioSalonServices usuarioSalonService)
        {
            _usuarioSalonService = usuarioSalonService;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UsuarioSalonRequestModel salon)
        {
            await _usuarioSalonService.Add(salon);
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UsuarioSalonRequestModel salon, int id)
        {
            await _usuarioSalonService.Update(salon, id);
            return Ok();
        }


        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioSalonService.Delete(id);
            return Ok();
        }


    }
}

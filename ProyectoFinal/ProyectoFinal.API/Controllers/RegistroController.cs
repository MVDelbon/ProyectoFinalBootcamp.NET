using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Models.Registro;
using ProyectoFinal.Application.Services.Interfaces;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegistroController : ControllerBase
    {
        public readonly IRegistroServices _registroService;

        public RegistroController(IRegistroServices registroService)
        {
            _registroService = registroService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RegistroRequestModel registro)
        {
            await _registroService.Add(registro);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RegistroRequestModel registro, int id)
        {
            await _registroService.Update(registro, id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegistros()
        {
            var registro = await _registroService.GetAll();
            return Ok(registro);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var registro = await _registroService.GetById(id);
            return Ok(registro);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _registroService.Delete(id);
            return Ok();
        }
    }
}

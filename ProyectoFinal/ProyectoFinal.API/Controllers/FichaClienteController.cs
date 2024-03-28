using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Models.FichaCliente;
using ProyectoFinal.Application.Services.Interfaces;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichaClienteController : ControllerBase
    {

        public readonly IFichaServices _fichasService;

        public FichaClienteController(IFichaServices fichaService)
        {
            _fichasService = fichaService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] FichaClienteRequestModel ficha)
        {
            await _fichasService.Add(ficha);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] FichaClienteRequestModel ficha, int id)
        {
            await _fichasService.Update(ficha, id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFichas()
        {
            var fichas = await _fichasService.GetAll();
            return Ok(fichas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ficha = await _fichasService.GetById(id);
            return Ok(ficha);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _fichasService.Delete(id);
            return Ok();
        }
    }
}

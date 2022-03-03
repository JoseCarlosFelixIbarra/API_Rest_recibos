using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Rest_recibos.Models;
using API_Rest_recibos.Services;
using Microsoft.AspNetCore.Cors;

namespace API_Rest_recibos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioController : ControllerBase
    {
        public usuario_service _usuario_serv;

        public usuarioController(usuario_service usuario_serv)
        {
            _usuario_serv = usuario_serv;
        }
        [EnableCors]
        [HttpPost("iniciar_sesion")]
        public IActionResult iniciar_sesion([FromBody] usuario_model objeto_usuario)
        {
            if (objeto_usuario == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var usuario = _usuario_serv.iniciar_sesion(objeto_usuario);
            return Ok(usuario);
        }
        [EnableCors]
        [HttpPost("insert_usuario")]
        public IActionResult insert_recibo([FromBody] usuario_model objeto_usuario)
        {
            if (objeto_usuario == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _usuario_serv.agregar_usuario(objeto_usuario);
            return Ok();
        }
    }
}

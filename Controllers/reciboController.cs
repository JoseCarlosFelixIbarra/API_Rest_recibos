using API_Rest_recibos.Context;
using API_Rest_recibos.Models;
using API_Rest_recibos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest_recibos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reciboController : ControllerBase
    {
        public recibo_service _recibo_serv;

        public reciboController(recibo_service recibo_serv)
        {
            _recibo_serv = recibo_serv;
        }

        [HttpGet("get_recibos_por_id_usuario/{id_usuario:long}")]
        public IActionResult get_recibos_por_id_usuario(long id_usuario)
        {
            var lista_recibos = _recibo_serv.obtener_recibos_por_usuario(id_usuario);
            return (lista_recibos == null) ? NotFound() : Ok(lista_recibos);

        }

        [HttpPost("insert_recibo")]
        public IActionResult insert_recibo([FromBody] recibo_model objeto_recibo)
        {
            if (objeto_recibo == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _recibo_serv.agregar_recibo(objeto_recibo);
            return Ok();
        }
        [HttpPut("update_recibo")]
        public IActionResult update_recibo([FromBody] recibo_model objeto_recibo)
        {
            if (objeto_recibo == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _recibo_serv.modificar_recibo(objeto_recibo);
            return Ok();
        }
        [HttpDelete("delete_recibo/{id_recibo:long}")]
        public IActionResult delete_recibo(long id_recibo)
        {
            _recibo_serv.eliminar_recibo(id_recibo);
            return Ok();
        }
    }
}
using API_Rest_recibos.Context;
using API_Rest_recibos.Models;
using System.Linq;
using System.Collections.Generic;

namespace API_Rest_recibos.Services
{
    public class recibo_service
    {
        private readonly ApplicationDBContext _appdbController;
        public recibo_service(ApplicationDBContext appdbController) {
            _appdbController = appdbController;
        }

        public void agregar_recibo(recibo_model objeto_recibo) { 
             _appdbController.Add(objeto_recibo);
             _appdbController.SaveChanges();
        }
        public void modificar_recibo(recibo_model objeto_recibo)
        {
            var recibo_resultado = _appdbController.recibo.FirstOrDefault(_recibo => _recibo.id == objeto_recibo.id);
            if (recibo_resultado != null)
            {

                recibo_resultado.proveedor_recibo = objeto_recibo.proveedor_recibo;
                recibo_resultado.moneda_recibo = objeto_recibo.moneda_recibo;
                recibo_resultado.fecha_recibo = objeto_recibo.fecha_recibo;
                recibo_resultado.monto_recibo = objeto_recibo.monto_recibo;
                recibo_resultado.comentario_recibo = objeto_recibo.comentario_recibo;

                _appdbController.SaveChanges();
            }
        }
        public List<recibo_model> obtener_recibos_por_usuario(long id_usuario) {
            List<recibo_model> lista_recibos = _appdbController.recibo.Where(_recibo => _recibo.id_usuario == id_usuario).ToList();
            return lista_recibos;
        }
        public void eliminar_recibo(long id_recibo)
        {
            var recibo_resultado = _appdbController.recibo.FirstOrDefault(_recibo => _recibo.id == id_recibo);
            if (recibo_resultado != null)
            {
                _appdbController.recibo.Remove(recibo_resultado);
                _appdbController.SaveChanges();
            }
            
        }
    }
}

using API_Rest_recibos.Context;
using API_Rest_recibos.Models;
using System.Linq;
using System.Collections.Generic;

namespace API_Rest_recibos.Services
{
    public class usuario_service
    {
        private readonly ApplicationDBContext _appdbController;

        public usuario_service(ApplicationDBContext appdbController)
        {
            _appdbController = appdbController;
        }
        public usuario_model iniciar_sesion(usuario_model objeto_usuario)
        {
            usuario_model usuario_existente = _appdbController.usuario.Where(_usuario =>
            (_usuario.correo_usuario == objeto_usuario.correo_usuario && _usuario.contrasenia_usuario == objeto_usuario.contrasenia_usuario)
            ).FirstOrDefault();
            return usuario_existente;

        }
        public void agregar_usuario(usuario_model objeto_usuario)
        {
            _appdbController.Add(objeto_usuario);
            _appdbController.SaveChanges();
        }
    }
   
}

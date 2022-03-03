using System.ComponentModel.DataAnnotations;

namespace API_Rest_recibos.Models
{
    public class usuario_model
    {
        [Key]
        public long id { get; set; }
        [Required]
        public string correo_usuario { get; set; }
        [Required]
        public string nombre_usuario { get; set; }
        [Required]
        public string apellido_usuario { get; set; }
        [Required]
        public string contrasenia_usuario { get; set; } 
    }
}

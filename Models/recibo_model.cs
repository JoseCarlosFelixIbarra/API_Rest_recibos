using System.ComponentModel.DataAnnotations; 

namespace API_Rest_recibos.Models
{
    public class recibo_model
    {
        [Key]
        public long id { get; set; }
        [Required]
        public string proveedor_recibo  { get; set; }
        [Required]
        public double monto_recibo { get; set; }
        [Required]
        public string moneda_recibo { get; set; }
        [Required]
        public string comentario_recibo { get; set; }
        [Required]
        public long id_usuario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime fecha_recibo { get; set; }
    }
}

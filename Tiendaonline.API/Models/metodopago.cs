
using System.ComponentModel.DataAnnotations;

namespace Tiendaonline.API.Models
{
    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;
    }
}
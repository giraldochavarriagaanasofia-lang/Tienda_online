
using System.ComponentModel.DataAnnotations;

namespace Tiendaonline.API.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public string? Telefono { get; set; }
    }
}
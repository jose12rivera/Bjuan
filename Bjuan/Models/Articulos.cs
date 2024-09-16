using System.ComponentModel.DataAnnotations;

namespace Bjuan.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "intentar")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}

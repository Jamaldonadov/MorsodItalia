using System.ComponentModel.DataAnnotations;

namespace MorsodItalia.BL
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la Categoría")]
        public string Descripcion { get; set; }
    }
}
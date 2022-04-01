using System.ComponentModel.DataAnnotations;

namespace MorsodItalia.BL
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}
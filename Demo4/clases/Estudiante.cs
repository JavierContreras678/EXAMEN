using System.ComponentModel.DataAnnotations;
namespace Demo4.clases
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El máximo de caracteres es 100")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo inválido")]
        [MaxLength(100, ErrorMessage = "El máximo de caracteres es 100")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "La calificación es obligatoria")]
        public int? Calificacion { get; set; }
    }
}

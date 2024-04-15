using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
namespace Demo4.Productos
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número positivo mayor a 0")]
        public string? Inventario { get; set; }


        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [MaxLength(200, ErrorMessage = "El máximo de caracteres es 200")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Departamento es obligatorio")]
        public string? Departamento { get; set; }



    }
}

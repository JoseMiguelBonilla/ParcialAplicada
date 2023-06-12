using System.ComponentModel.DataAnnotations;

namespace ParcialAplicada.Models
{
    public class Libros
    {
        [Key]
        public int LibroId {get; set;}
        [Required(ErrorMessage = "El titulo del libro es requerido")]

        public string? Titulo {get;set;}
        [Required(ErrorMessage = "El precio es requerido")]

        public int Precio {get;set;}
    }
}
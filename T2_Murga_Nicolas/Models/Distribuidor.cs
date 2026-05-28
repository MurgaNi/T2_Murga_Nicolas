using System.ComponentModel.DataAnnotations;

namespace T2_Murga_Nicolas.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del distribuidor es obligatorio.")]
        [Display(Name = "Nombre del Distribuidor")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razón social es obligatoria.")]
        [Display(Name = "Razón Social")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El teléfono de contacto es obligatorio.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El año de inicio es obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El año debe estar entre 1900 y 3000.")]
        [Display(Name = "Año de Inicio de Operación")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El nombre de contacto es obligatorio.")]
        [Display(Name = "Contacto")]
        public string Contacto { get; set; }
    }
}
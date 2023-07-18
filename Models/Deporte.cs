using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Cartagena_Zumarraga.Models
{
    public class Deporte
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el asunto a tratar")]
        [StringLength(30)]
        public string? AsuntoDep { get; set; }

        [Required(ErrorMessage = "Ingrese su aporte")]
        public string? CuerpoDep { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-aa}")]
        public DateTime FechaDep { get; set; }

    }
}

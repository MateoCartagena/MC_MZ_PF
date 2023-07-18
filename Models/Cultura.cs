using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Cartagena_Zumarraga.Models
{
    public class Cultura
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el asunto a tratar")]
        [StringLength(30)]
        public string? AsuntoCul { get; set; }

        [Required(ErrorMessage = "Ingrese su aporte")]
        public string? CuerpoCul { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-aa}")]
        public DateTime FechaCul { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Cartagena_Zumarraga.Models
{
    public class Arte
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el asunto a tratar")]
        [StringLength(30)]
        public string? AsuntoArt { get; set; }

        [Required(ErrorMessage = "Ingrese su aporte")]
        public string? CuerpoArt { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-aa}")]
        public DateTime FechaArt { get; set; }

    }
}

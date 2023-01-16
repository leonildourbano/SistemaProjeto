using System.ComponentModel.DataAnnotations;

namespace ProjEscola.Models
{
    public class ProjTurma
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "NomeTurma")]
        [Required(ErrorMessage = "O nome da Turma é obrigatório", AllowEmptyStrings = false)]
        public string? NomeTurma { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DataInicioTurma { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataTerminoTurma { get; set; }

       public string? TipoTurma { get; set; }
       public string? HorarioTurma { get; set; }
    }
}

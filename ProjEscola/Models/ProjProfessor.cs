using System.ComponentModel.DataAnnotations;

namespace ProjEscola.Models
{
    public class ProjProfessor
    {
        [Key]
        public int Id { get; set; }
        public string? NomeProfessor { get; set; }
        public string? EmailProfessor { get; set; }
        public decimal? ValorHoraProfessor { get; set; }
        public string? DisponibilidadeHorarioProfessor { get; set; }
        public string? CertificadosProfessor { get; set; }
    }
}

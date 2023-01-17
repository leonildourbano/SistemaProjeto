using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace ProjEscola.Models
{
    public class ProjEstudante
    {
        [Key]
        public int Id { get; set; }
        public string? NomeEstudante { get; set;}

        public string? EmailEstudante { get; set; }

        public string? FoneEstudante { get; set; }

        public string? DataNascimentoEstudante { get; set; }
        
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjEscola.Models
{
    public class TurmaTipoViewModel
    {
        public List<ProjTurma>? Turmas { get; set; }
        public SelectList? Tipos { get; set; }
        public string? TipoTurma { get; set; }
        public string? SearchString { get; set; }
    }
}


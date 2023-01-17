using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjEscola.Models
{
    public class TurmaTipoViewModel
    {
        public List<ProjTurma>? Turmas { get; set; }
        public SelectList? TipoTurma { get; set; }
        public string? Tipos { get; set; }
        public string? SearchString { get; set; }
    }
}


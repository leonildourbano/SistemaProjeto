using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjEscola.Models;

namespace ProjEscola.Data
{
    public class ProjEscolaContext : DbContext
    {
        public ProjEscolaContext (DbContextOptions<ProjEscolaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjEscola.Models.ProjEstudante> ProjEstudante { get; set; } = default!;

        public DbSet<ProjEscola.Models.ProjProfessor> ProjProfessor { get; set; }

        public DbSet<ProjEscola.Models.ProjTurma> ProjTurma { get; set; }
    }
}

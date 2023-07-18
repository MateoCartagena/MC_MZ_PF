using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Cartagena_Zumarraga.Models;

namespace MC_MZ_PF.Data
{
    public class MC_MZ_PFContext : DbContext
    {
        public MC_MZ_PFContext (DbContextOptions<MC_MZ_PFContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoFinal_Cartagena_Zumarraga.Models.Arte> Arte { get; set; } = default!;

        public DbSet<ProyectoFinal_Cartagena_Zumarraga.Models.Cultura>? Cultura { get; set; }

        public DbSet<ProyectoFinal_Cartagena_Zumarraga.Models.Deporte>? Deporte { get; set; }

        public DbSet<ProyectoFinal_Cartagena_Zumarraga.Models.Tecnologia>? Tecnologia { get; set; }
    }
}

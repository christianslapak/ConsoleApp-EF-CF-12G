using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_EF_CF_12G
{
    class EscuelaContext:DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=EscuelaDB-2023-CF12G;Trusted_Connection=True;"); }
    }
}

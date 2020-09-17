using BoletimEscolar.Modelos;
using Microsoft.EntityFrameworkCore;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{


    public class Bd : DbContext
    {

        public Bd()
        {

        }
        public Bd(DbContextOptions<Bd> options) : base(options)
        {

        }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-03374/SQLEXPRESS;Initial Catalog=Boletim;Integrated Security=True;MultipleActiveResultSets=True");
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Bd).Assembly);

            modelBuilder.Entity<Aluno>()
           .HasOne(p => p.Curso)
           .WithMany(b => b.Alunos)
           .HasForeignKey(p => p.IdCurso);

            

            modelBuilder.Entity<Materia>()
         .HasOne(p => p.Curso)
         .WithMany(b => b.Materias)
         .HasForeignKey(p => p.IdCurso);

          modelBuilder.Entity<MateriaAluno>().HasKey(sc => new { sc.IdAluno, sc.IdMateria});
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server==NT-03374\\SQLEXPRESS;Database=master;Initial Catalog=Boletim;");
            }

            base.OnConfiguring(optionsBuilder);
        }


    }

}

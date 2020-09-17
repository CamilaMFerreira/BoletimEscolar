using System;
using System.Collections.Generic;
using System.Text;

using BoletimEscolar.Modelos;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-03374/SQLEXPRESS;Initial Catalog=Boletim;Integrated Security=True;MultipleActiveResultSets=True");
        }


        public DbSet<Curso> Curso { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Notas> Nota { get; set; }

    }



}


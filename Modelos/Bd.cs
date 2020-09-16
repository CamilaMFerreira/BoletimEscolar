using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BoletimEscolar.Modelos;
using System.Reflection;

namespace Modelos
{
    public class Bd : DbContext
    {
        
        
            public Bd() : base("DefaultConnection")
            {
            }

            public DbSet<Curso> Curso{ get; set; }
            public DbSet<Aluno> Aluno { get; set; }
            public DbSet<Materia> Materia { get; set; }
             public DbSet<Notas> Nota { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

                modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

                base.OnModelCreating(modelBuilder);
            }


        
    }
}

using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Modelos.Type
{
    public class CursoConfig : EntityTypeConfiguration<Curso>
    {
        public CursoConfig() 
        {
            HasKey(q => q.Id);
            Property(q => q.Nome).IsRequired().HasMaxLength(100);
            Property(q => q.Situação).IsRequired();
           // HasMany(q => q.Alunos).WithRequired().HasForeignKey(q => q.IdCurso);
           // HasMany(q => q.Materias).WithRequired().HasForeignKey(q => q.IdCurso);

        }
            

    }
}

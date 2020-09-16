using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Modelos.Type
{
    public class NotasConfig : EntityTypeConfiguration<Notas>
    {
        public NotasConfig()
        {

            HasKey(q => q.Id);
            Property(q => q.Nota).IsRequired();
            HasRequired(q => q.Alunos).WithMany().HasForeignKey(q => q.IdAluno);
            HasRequired(q => q.Materias).WithMany().HasForeignKey(q => q.IdMateria);


        }
    }
}

using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Modelos.Type
{
    public class MateriasConfig : EntityTypeConfiguration<Materia>
    {
        public MateriasConfig()
        {
            HasKey(q => q.Id);
            Property(q => q.Descrição).IsRequired();
            Property(q => q.DataCadastro).IsRequired();
            Property(q => q.Situação).IsRequired();
            //HasRequired(q => q.Curso).WithMany().HasForeignKey(q => q.IdCurso);
           // HasMany(q => q.Notas).WithRequired().HasForeignKey(q => q.IdMateria);
        }
       
    }
}

using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Modelos.Type
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        
            public AlunoConfig()
            {

                HasKey(q => q.Id);
                Property(q => q.Nome).IsRequired().HasMaxLength(100);
                Property(q => q.Sobrenome).IsRequired().HasMaxLength(100);
                Property(q => q.Cpf).IsRequired().HasMaxLength(100);
                Property(q => q.DataNascimento).IsRequired();
               // HasMany(q => q.Notas).WithRequired().HasForeignKey(q => q.IdAluno);
               // HasRequired(q => q.Notas).WithMany().HasForeignKey(q => q.IdNotas);


        }

        
    }
}

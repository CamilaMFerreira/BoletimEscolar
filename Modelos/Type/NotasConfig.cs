using BoletimEscolar.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modelos.Type
{
    public class NotasConfig : IEntityTypeConfiguration<Notas>
    {

        public void Configure(EntityTypeBuilder<Notas> builder)
        {

            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nota).IsRequired();
            builder.HasOne(x => x.Alunos).WithMany().HasForeignKey(x => x.IdAluno);
            builder.HasOne(x => x.Materias).WithMany().HasForeignKey(x => x.IdMateria);
        }
    }
}

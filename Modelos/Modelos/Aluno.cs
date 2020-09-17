using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimEscolar.Modelos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public int IdCurso { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<MateriaAluno> Materias { get; set; } = new HashSet<MateriaAluno>();
        public ICollection<Notas> Notas { get; set; } = new HashSet<Notas>();

    }
}

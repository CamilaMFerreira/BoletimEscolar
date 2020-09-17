using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimEscolar.Modelos
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Situação { get; set; }
        public ICollection<Materia> Materias { get; set; } = new HashSet<Materia>();
        public ICollection<Aluno> Alunos{ get; set; } = new HashSet<Aluno>();

    }
}
